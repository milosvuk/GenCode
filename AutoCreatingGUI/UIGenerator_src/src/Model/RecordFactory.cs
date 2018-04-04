using System;
using System.Data;
using Greco.Db;
using Greco.Util;

namespace Greco.Model {
/// <summary>
/// Summary description for RecordFactory.
/// </summary>
public class RecordFactory {

  //----------------------------------------------------------------------------
  //  ExecuteReader
  //----------------------------------------------------------------------------  
  public static IRecordReader ExecuteReader(IDbConnection dbConnection, RecordInfo recordInfo, object parameters) {
    return ExecuteReader(dbConnection, recordInfo, parameters, false);
  }
  
  public static IRecordReader ExecuteReader(IDbConnection dbConnection, RecordInfo recordInfo) {
    return ExecuteReader(dbConnection, recordInfo, null);
  }

  public static IRecordReader ExecuteReader(IDbConnection dbConnection, string fileName, object parameters) {
    RecordInfo recordInfo = RecordInfoFactory.CreateRecordInfo(fileName, false);
    return ExecuteReader(dbConnection, recordInfo, parameters);
  }

  public static IRecordReader ExecuteReader(IDbConnection dbConnection, string fileName) {
    return ExecuteReader(dbConnection, fileName, null);
  }

  public static IRecordReader ExecuteReader(IDbConnection dbConnection, RecordInfo recordInfo,
                                            object parameters, bool selectOne) {
    // TODO : faire appel à un autre IRecordFactory avec nom classe dans le RecordInfo
    return DbFactory.DbProvider.ExecuteReader(dbConnection, recordInfo, parameters, selectOne);
  }

  //----------------------------------------------------------------------------  
  //  CreateRecordTable
  //----------------------------------------------------------------------------  
  public static RecordTable CreateRecordTable(IDbConnection dbConnection, RecordInfo recordInfo, object parameters) {
    return CreateRecordTable(dbConnection, recordInfo, parameters, false);
  }

  public static RecordTable CreateRecordTable(IDbConnection dbConnection, RecordInfo recordInfo) {
    return CreateRecordTable(dbConnection, recordInfo, null);
  }
  
  public static RecordTable CreateRecordTable(IDbConnection dbConnection, string fileName, object parameters) {
    // on ne parse que la partie sql et les paramètres, le reste est parsé après le select
    RecordInfo recordInfo = RecordInfoFactory.CreateRecordInfo(fileName, false);
    return CreateRecordTable(dbConnection, recordInfo, parameters);
  }
  
  public static RecordTable CreateRecordTable(IDbConnection dbConnection, string fileName) {
    return CreateRecordTable(dbConnection, fileName, null);
  }

  public static RecordTable CreateRecordTable(IDbConnection dbConnection, RecordInfo recordInfo,
    object parameters, bool selectOne) {
    RecordInfoParser recordInfoParser = RecordInfoFactory.GetInstance().RecordInfoParser;
    RecordTable rt = null;
    if (!recordInfo.autoLoad) {
      // liste avec critères de recherche
      if (!recordInfo.parsingDone && !recordInfo.autoColumns) {
        // description des colonnes faite lors du 1er select
        recordInfoParser.Parse2(recordInfo);
        recordInfoParser.Parse3(recordInfo);
        recordInfo.parsingDone = true;
      }
      rt = new RecordTable(recordInfo);
      if (rt.RecordInfo.ParametersInfo != null) rt.Parameters = parameters;
      return rt;
    }
    
    if (recordInfoParser.HasStaticValues(recordInfo)) {
      // valeurs en dur dans le fichier de description
      if (!recordInfo.parsingDone) {
        recordInfoParser.Parse2(recordInfo);
        recordInfoParser.Parse3(recordInfo);
        recordInfo.parsingDone = true;
      }
      rt = recordInfo.StaticRecordTable;
      if (rt.RecordInfo.ParametersInfo != null) rt.Parameters = parameters;
      return rt;
    }
    
    IRecordReader recordReader = ExecuteReader(dbConnection, recordInfo, parameters, selectOne);
    return CreateRecordTable(recordReader);
  }
  
  public static RecordTable CreateRecordTable(IRecordReader recordReader) {
    RecordTable rt;
    try {
      rt = new RecordTable(recordReader.RecordInfo);
      if (rt.RecordInfo.ParametersInfo != null) rt.Parameters = recordReader.Parameters;
      
      rt.DataTable.BeginLoadData();
      while (recordReader.Read()) {
        Record rec = recordReader.CurrentRecord;
        rt.Add(rec);
      }
      rt.DataTable.EndLoadData();
    }
    finally {
      if (recordReader != null) recordReader.Close();
    }
    return rt;
  }
  
  //----------------------------------------------------------------------------  
  //  GetRecord
  //----------------------------------------------------------------------------  
  public static Record GetRecord(IDbConnection dbConnection, RecordInfo recordInfo, object parameters) {
    if (recordInfo.StaticRecordTable == null) {
      RecordTable rt = CreateRecordTable(dbConnection, recordInfo, parameters, true);
      if (rt.Count == 0) throw new DbException(recordInfo.Name + " : no data found");
      else if (rt.Count > 1) throw new DbException(recordInfo.Name + ", selectOne : " + rt.Count + " rows found");
      return rt[0];
    }
    else {
      // RecordTable statique, on doit comparer les clés primaires
      Record rec = null;
      for (int i = 0; i < recordInfo.StaticRecordTable.Count; i++) {
        rec = recordInfo.StaticRecordTable[i];
        if (rec.EqualsPKey(parameters)) return rec;
      }
      throw new DbException(recordInfo.Name + " : no data found (no matching primary key in StaticRecordTable)");
    }
  }
  
  public static Record GetRecord(IDbConnection dbConnection, string fileName, object parameters) {
    // on est obligé de tout parser pour avoir la définition des clés primaires utilisées en paramètres
    RecordInfo recordInfo = RecordInfoFactory.CreateRecordInfo(fileName, true);
    return GetRecord(dbConnection, recordInfo, parameters);
  }
  
  //----------------------------------------------------------------------------  
  //  ExecuteWriter
  //----------------------------------------------------------------------------  
  public static void ExecuteWriter(IDbConnection dbConnection, Record rec) {
    ExecuteWriter(dbConnection, null, rec);
  }
  
  public static void ExecuteWriter(IDbTransaction dbTransaction, Record rec) {
    ExecuteWriter(dbTransaction.Connection, dbTransaction, rec);
  }
  
  public static void ExecuteWriter(IDbConnection dbConnection, IDbTransaction dbTransaction, RecordTable rt) {
    // TODO : si non persistant, remettre l'état des lignes à Unchanged ?
    if (!rt.RecordInfo.IsPersistent) return;
    // TODO : faire appel à un autre IRecordFactory avec nom classe dans le RecordInfo
    DbFactory.DbProvider.ExecuteWriter(dbConnection, dbTransaction, rt);
  }

  public static void ExecuteWriter(IDbConnection dbConnection, IDbTransaction dbTransaction, Record rec) {
    if (rec.State == DataRowState.Unchanged) return;
    // TODO : dans ce cas, faudrait s'assurer que le record est bien sauvegardé dans son record set
    if (!rec.RecordInfo.IsPersistent) return;
    // TODO : faire appel à un autre IRecordFactory avec nom classe dans le RecordInfo
    DbFactory.DbProvider.ExecuteWriter(dbConnection, dbTransaction, rec);
  }
}


}  // namespace
