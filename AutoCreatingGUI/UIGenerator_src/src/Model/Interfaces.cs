using System;
using System.Collections;
using System.Data;

namespace Greco.Model {

/// <summary>
/// Summary description for IRecordEnumerator.
/// </summary>
public interface IRecordEnumerator : IEnumerator {
  Record CurrentRecord { get; }
}

/// <summary>
/// Description résumée de IRecordReader.
/// </summary>
public interface IRecordReader : IRecordEnumerator {
  RecordInfo RecordInfo { get; }
  int Depth { get; }
  bool IsClosed { get; }
  int RecordsAffected { get; }
  void Close();
  DataTable GetSchemaTable();
  bool NextResult();
  bool Read();
  int RowNum { get; }
  object Parameters { get; }
}

/// <summary>
/// Description résumée de IRecordWriter.
/// </summary>
public interface IRecordWriter {
  void ExecuteWriter(IDbConnection dbConnection, IDbTransaction dbTransaction, Record rec);
  void ExecuteWriter(IDbConnection dbConnection, IDbTransaction dbTransaction, RecordTable rt);  
}


/// <summary>
/// Summary description for IRecordProvider.
/// </summary>
public interface IRecordProvider : IRecordWriter {
  IRecordReader ExecuteReader(IDbConnection dbConnection, RecordInfo recordInfo,
                              object parameters, bool selectOne);
}


} // namespace
