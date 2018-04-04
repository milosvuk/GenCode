// RecordTable.cs
//
using System;
using System.Data;
using System.Globalization;
using Greco.Util;

namespace Greco.Model {

/// <summary>
/// Summary description for RecordTable.
/// </summary>
public class RecordTable : RecordInfoHolder {
  protected DataTable dataTable;
  private Record parametersRecord;

  /// <summary>
  /// Creates a new instance of RecordTable
  /// </summary>
  public RecordTable(RecordInfo recordInfo, DataTable dataTable) : base(recordInfo) {
    this.dataTable = dataTable;
  }

  public RecordTable(RecordInfo recordInfo) : base(recordInfo) {
    dataTable = recordInfo.CreateDataTable();
  }

  public RecordTable(DataTable dataTable) : base(new RecordInfo(dataTable)) {
    this.dataTable = dataTable;
  }

  public DataTable DataTable {
    get { return dataTable; }
    // pas de set, le dataTable est rattaché de façon définitive à son RecordTable
  }

  public Record ParametersRecord {
    get { return parametersRecord; }
    set {
      if (recordInfo.ParametersInfo == null) {
        if (value != null)
          throw new ModelException(recordInfo, "No parameters info, cannot set value " + value);
        return;
      }
      if (parametersRecord == null) parametersRecord = new Record(recordInfo.ParametersInfo);
      parametersRecord.FromRecord(value, false);
    }
  }

  public object Parameters {
    get { return parametersRecord; }
    set {
      if (recordInfo.ParametersInfo == null) {
        if (value != null)
          throw new ModelException(recordInfo, "No parameters info, cannot set value " + value);
        return;
      }
      if (parametersRecord == null) parametersRecord = new Record(recordInfo.ParametersInfo);

      Record rec = value as Record;
      if (rec != null) parametersRecord.FromRecord(rec);
      else {
        object[] array = value as object[];
        if (array != null) {
          parametersRecord.FromArray(array);
          return;
        }
        else if (parametersRecord.RecordInfo.Fields.Count == 1) {
          parametersRecord[0] = value;
          return;
        }
        else throw new ModelException(recordInfo, "Invalid parameters " + value);
      }
    }
  }

  // DataTable
  public void AcceptChanges() {
    dataTable.AcceptChanges();
  }

  public void RejectChanges() {
    dataTable.RejectChanges();
  }

  public void Reset() {
    dataTable.Reset();
  }

  // DataRowCollection
  public int Count {
    get { return dataTable.Rows.Count; }
  }

  public bool IsReadOnly {
    get { return dataTable.Rows.IsReadOnly; }
  }

  public bool IsSynchronized {
    get { return dataTable.Rows.IsSynchronized; }
  }

  public void Clear() {
    dataTable.Rows.Clear();
  }

  public bool Contains(object o) {
    return dataTable.Rows.Contains(o);
  }

  public bool Contains(object[] objects) {
    return dataTable.Rows.Contains(objects);
  }

  // Gestion des valeurs et des records
  public object this[int row, int column] {
    get {
      DataRow dataRow = dataTable.Rows[row];
      return dataRow[column];
    }
    set {
      DataRow dataRow = dataTable.Rows[row];
      dataRow[column] = recordInfo.Fields[column].Validate(value);
    }
  }

  public object this[int row, string column] {
    get {
      DataRow dataRow = dataTable.Rows[row];
      return dataRow[column];
    }
    set {
      DataRow dataRow = dataTable.Rows[row];
      dataRow[column] = recordInfo.Fields[column].Validate(value);
    }
  }

  public Record this[int index] {
    get {
      DataRow dataRow = dataTable.Rows[index];
      return new Record(recordInfo, this, dataRow);
    }
    set {
      DataRow dataRow = dataTable.Rows[index];
      value.ToDataRow(dataRow);
    }
  }


  // DataTable
  public Record NewRecord() {
    DataRow dataRow = dataTable.NewRow();
    return new Record(recordInfo, this, dataRow);
  }

  public void Add(Record record) {
    DataRow dataRow = record.DataRow;
    if ((dataRow == null) || (dataRow.Table != dataTable)) {
      dataRow = dataTable.NewRow();
      record.ToDataRow(dataRow);
    }
    dataTable.Rows.Add(dataRow);
    // Log.Info("Record.Add : " + record);
  }

  public void Add(object[] values) {
    Record rec = NewRecord();
    rec.FromArray(values);
    Add(rec);
  }
  
  public void InsertAt(Record record, int pos) {
    dataTable.Rows.InsertAt(record.SafeDataRow, pos);
    // Log.Info("Record.InsertAt : " + pos + " , " + record);
  }

  public void Remove(Record record) {
    dataTable.Rows.Remove(record.SafeDataRow);
    // Log.Info("Record.Remove : " + record);
  }

  public void RemoveAt(int index) {
    dataTable.Rows.RemoveAt(index);
    // Log.Info("Record.RemoveAt : " + index);
  }

  public DataRowState StateAt(int index) {
    return dataTable.Rows[index].RowState;
  }

  public override string ToString() {
    string s = "RecordTable " + recordInfo.Name + "\n";
    s += "  cols = ";
    for (int i = 0; i < recordInfo.Fields.Count; i++) {
      if (i > 0) s += ", ";
      s += recordInfo.Fields[i].Name;
    }
    s += "\n";
    for (int i = 0; i < Count; i++) {
      Record rec = this[i];
      s += "  row " + i + " = " + rec + "\n";
    }
    return s;
  }

  public void ExecuteReader(IDbConnection dbConnection) {
    IRecordReader recordReader = RecordFactory.ExecuteReader(dbConnection, recordInfo, parametersRecord);
    try {
      dataTable.BeginLoadData();
      while (recordReader.Read()) {
        Record rec = recordReader.CurrentRecord;
        Add(rec);
      }
      dataTable.EndLoadData();
    }
    finally {
      recordReader.Close();
    }
  }

  public object GetValueAt(int row, int column) {
    DataRow dataRow = dataTable.Rows[row];
    return dataRow[column];
  }

  public object GetValueAt(int row, string column) {
    DataRow dataRow = dataTable.Rows[row];
    return dataRow[column];
  }

  public void SetValueAt(int row, int column, object val) {
    DataRow dataRow = dataTable.Rows[row];
    dataRow[column] = recordInfo.Fields[column].Validate(val);
  }

  public void SetValueAt(int row, string column, object val) {
    DataRow dataRow = dataTable.Rows[row];
    dataRow[column] = recordInfo.Fields[column].Validate(val);
  }

  public string GetStringAt(int row, int column) {
    return DataConverter.ToString(GetValueAt(row, column));
  }

  public string GetStringAt(int row, string column) {
    return DataConverter.ToString(GetValueAt(row, column));
  }

  public string GetStringAt(int row, int column, CultureInfo cultureInfo) {
    return DataConverter.ToString(GetValueAt(row, column), cultureInfo);
  }

  public string GetStringAt(int row, string column, CultureInfo cultureInfo) {
    return DataConverter.ToString(GetValueAt(row, column), cultureInfo);
  }

  public int GetIntAt(int row, int column) {
    if (recordInfo.Fields[column].DbType != DbType.Int32) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (int) val;
  }

  public int GetIntAt(int row, string column) {
    if (recordInfo.Fields[column].DbType != DbType.Int32) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (int) val;
  }

  public bool GetBoolAt(int row, int column) {
    if (recordInfo.Fields[column].DbType != DbType.Boolean) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (bool) val;
  }

  public bool GetBoolAt(int row, string column) {
    if (recordInfo.Fields[column].DbType != DbType.Boolean) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (bool) val;
  }

  public DateTime GetDateTimeAt(int row, int column) {
    if (recordInfo.Fields[column].DbType != DbType.DateTime) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (DateTime) val;
  }

  public DateTime GetDateTimeAt(int row, string column) {
    if (recordInfo.Fields[column].DbType != DbType.DateTime) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (DateTime) val;
  }

  public DateTime GetDateAt(int row, int column) {
    if (recordInfo.Fields[column].DbType != DbType.Date) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (DateTime) val;
  }

  public DateTime GetDateAt(int row, string column) {
    if (recordInfo.Fields[column].DbType != DbType.Date) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (DateTime) val;
  }

  public TimeSpan GetTimeAt(int row, int column) {
    if (recordInfo.Fields[column].DbType != DbType.Time) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (TimeSpan) val;
  }

  public TimeSpan GetTimeAt(int row, string column) {
    if (recordInfo.Fields[column].DbType != DbType.Time) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValueAt(row, column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");    
    return (TimeSpan) val;
  }
}


} // namespace
