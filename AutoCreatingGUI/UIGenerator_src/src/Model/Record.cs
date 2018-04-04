// Record.cs
//
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Data;
using Greco.Util;

namespace Greco.Model {

/// <summary>
/// Summary description for Record.
/// </summary>
public class Record : RecordInfoHolder {
  protected DataRow dataRow;
  protected object[] values;
  protected object[] oldValues;
  protected DataRowState initialState, state;
  protected bool[] changedFields;
  protected bool readOnly;
  protected RecordTable recordTable;

  /// <summary>
  /// Creates a new instance of Record
  /// </summary>
  public Record(RecordInfo recordInfo, RecordTable recordTable, DataRow dataRow) : base(recordInfo) {
    this.recordTable = recordTable;
    this.dataRow = dataRow;
    values = new object[recordInfo.Fields.Count];
    changedFields = null;
    readOnly = false;
    if (dataRow != null) {
      // Record rattaché à un RecordTable via le dataRow
      FromDataRow(dataRow);
      initialState = state = dataRow.RowState;
    }
    else {
      // Record autonome
      initialState = state = DataRowState.Detached;
      for (int i = 0; i < recordInfo.Fields.Count; i++) {
        if (recordInfo.Fields[i].DefaultValue != null) values[i] = recordInfo.Fields[i].DefaultValue;
      }
    }
    oldValues = (object[]) values.Clone();
    renderInfo = null;
  }

  public Record(RecordInfo recordInfo, RecordTable recordTable) : this(recordInfo, recordTable, null) { }

  public Record(RecordInfo recordInfo, DataRow dataRow) : this(recordInfo, null, dataRow) { }

  public Record(RecordInfo recordInfo) : this(recordInfo, null, null) { }

  public object this[int i] {
    get { return GetValue(i); }
    set { SetValue(i, value); }
  }

  public object this[string name] {
    get { return GetValue(recordInfo.GetFieldIndex(name)); }
    set { SetValue(recordInfo.GetFieldIndex(name), value); }
  }

  public RecordTable RecordTable {
    get { return recordTable; }
  }

  public DataRow DataRow {
    get { ToDataRow(); return dataRow; }
    // le dataRow est initialisé dans le constructeur ou via SafeDataRow
    // set { dataRow = value; }
  }

  public DataRowState State {
    get { return state; }
    set { state = value; }
  }

  public bool ReadOnly {
    get { return readOnly; }
    set { readOnly = value; }
  }

  public object[] Values {
    get { return values; }
  }

  public object GetValue(int i) {
    /* pas d'utilisation de DBNull sauf au moment de l'enregistrement en base
    object o = values[i];
    return (o == null) ? DBNull.Value : o;
    */
    return values[i];
  }

  public object GetValue(string name)
  { return GetValue(recordInfo.GetFieldIndex(name)); }

  public void SetValue(int i, object o, bool checkValue, CultureInfo cultureInfo) {
    object oldValue = values[i];
    values[i] = recordInfo.Fields[i].Validate(o, checkValue, cultureInfo);
    if (values[i] == null) {
      if (oldValue != null) {
        if ((State != DataRowState.Added) && (State != DataRowState.Detached))
          State = DataRowState.Modified;
        SetChanged(i);
      }
    }
    else if (!values[i].Equals(oldValue)) {
      if ((State != DataRowState.Added) && (State != DataRowState.Detached))
        State = DataRowState.Modified;
      SetChanged(i);
    }
  }

  public void SetValue(int i, object o, CultureInfo cultureInfo)
  { SetValue(i, o, true, cultureInfo); }
  public void SetValue(string name, object o, bool checkValue, CultureInfo cultureInfo)
  { SetValue(recordInfo.GetFieldIndex(name), o, checkValue, cultureInfo); }
  public void SetValue(string name, object o, CultureInfo cultureInfo)
  { SetValue(recordInfo.GetFieldIndex(name), o, true, cultureInfo); }

  public void SetValue(int i, object o)
  { SetValue(i, o, true, null); }
  public void SetValue(int i, object o, bool checkValue)
  { SetValue(i, o, checkValue, null); }
  public void SetValue(string name, object o, bool checkValue)
  { SetValue(recordInfo.GetFieldIndex(name), o, checkValue, null); }
  public void SetValue(string name, object o)
  { SetValue(recordInfo.GetFieldIndex(name), o, true, null); }

  public void SetChanged(int i, bool b) {
    if (changedFields == null) {
      changedFields = new bool[recordInfo.Fields.Count];
      for (int j = 0; j < changedFields.Length; j++) changedFields[j] = false;
    }
    changedFields[i] = b;
  }

  public void SetChanged(int i)
  { SetChanged(i, true); }
  public void SetChanged(string name, bool b)
  { SetChanged(recordInfo.GetFieldIndex(name), b); }
  public void SetChanged(string name)
  { SetChanged(name, true); }

  public bool HasChanged(int i) {
    return (changedFields == null) ? false : changedFields[i];
  }
  public bool HasChanged(string name)
  { return HasChanged(name); }

  public bool IsNull(int i)
  { return (Convert.DBNull.Equals(values[i]) || (values[i] == null)); }

  public bool IsNull(string name)
  { return IsNull(recordInfo.GetFieldIndex(name)); }

  public bool IsNotNull(int i)
  { return !IsNull(i); }

  public bool IsNotNull(string name)
  { return !IsNull(name); }

  public void SetNull(int i)
  { values[i] = null; }

  public void SetNull(string name)
  { SetNull(recordInfo.GetFieldIndex(name)); }

  public void ResetChanged() {
    if (changedFields != null)
      for (int i = 0; i < changedFields.Length; i++) changedFields[i] = false;
  }

  public virtual void AcceptChanges() {
    if (dataRow != null) {
      ToDataRow(dataRow);
      dataRow.AcceptChanges();
      state = dataRow.RowState;
    }
  }

  public void RejectChanges() {
    if (dataRow != null) {
      dataRow.RejectChanges();
      FromDataRow(dataRow);
      state = dataRow.RowState;
      changedFields = null;
    }
    else {
      state = initialState;
      values = (object[]) oldValues.Clone();
      oldValues = (object[]) values.Clone();
    }
  }

  public void ToDataRow(DataRow dataRow) {
    if (dataRow == null) {
      if (this.dataRow != null) ToDataRow(this.dataRow);
      else return;
    }
    foreach (DataColumn col in dataRow.Table.Columns) {
      string name = col.ColumnName;
      if (recordInfo.Contains(name)) {
        object val = GetValue(name);
        dataRow[name] = (val == null) ? DBNull.Value : val;
      }
    }
  }

  public void ToDataRow()
  { ToDataRow(dataRow); }

    // recopier les data
  public void FromDataRow(DataRow dataRow, bool validate) {
    if (dataRow == null) {
      if (this.dataRow != null) FromDataRow(this.dataRow);
      else return;
    }
    foreach (DataColumn col in dataRow.Table.Columns) {
      string name = col.ColumnName;
      if (recordInfo.Contains(name)) SetValue(name, dataRow[name], validate);
    }
  }

  public void FromDataRow(DataRow dataRow)
  { FromDataRow(dataRow, true); }

  // retourne un DataRow mÃªme si celui en variable membre est nul
  public DataRow SafeDataRow {
    get {
      if (dataRow == null) {
        RecordTable rt = new RecordTable(recordInfo);
        dataRow = rt.DataTable.NewRow();
      }
      // TODO : accepter les changements ?
      ToDataRow();
      return dataRow;
    }
  }

  // recopier les data
  public void FromRecord(Record record, bool validate) {
    if (record == null) {
      for (int i = 0; i < recordInfo.Fields.Count; i++) SetValue(i, null, false);
      return;
    }
    foreach (FieldMetaData field in record.RecordInfo.Fields) {
      string name = field.Name;
      if (recordInfo.Contains(name)) SetValue(name, record[name], validate);
    }
  }
  
  public void FromRecord(Record record) { FromRecord(record, true); }
  
  public void FromArray(object[] values, bool validate) {
    if (values.Length != recordInfo.Fields.Count)
      throw new ModelException(recordInfo, "Values count doesn't match description");
    for (int i = 0; i < recordInfo.Fields.Count; i++) SetValue(i, values[i], validate);
  }

  public void FromArray(object[] values) { FromArray(values, true); }

  public void FromDictionary(IDictionary dict, bool validate) {
    foreach (DictionaryEntry entry in dict) {
      string key = entry.Key as string;
      if (key == null) continue;
      if (recordInfo.Contains(key)) SetValue(key, entry.Value, validate);
    }
  }

  public void FromDictionary(IDictionary dict) { FromDictionary(dict, true); }

  public void FromNameValueCollection(NameValueCollection nvc, bool validate, string prefix) {
    for (int i = 0; i < nvc.Keys.Count; i++) {
      string key = nvc.Keys[i];
      if (prefix != null) {
        if (key.StartsWith(prefix)) key = key.Substring(prefix.Length);
        else continue;
      }
      if (recordInfo.Contains(key)) SetValue(key, nvc[i], validate);
    }
  }

  public void FromNameValueCollection(NameValueCollection nvc, string prefix) {
    FromNameValueCollection(nvc, true, prefix);
  }

  public void FromNameValueCollection(NameValueCollection nvc) {
    FromNameValueCollection(nvc, true, null);
  }

  public override string ToString() {
    string s = "Record " + recordInfo.Name + ", values = ";
    bool first = true;
    foreach (object o in values) {
      if (first) {
        s += "\"" + o + "\"";
        first = false;
      }
      else s += ", \"" + o + "\"";
    }
    return s + ", state = " + state;
  }

  public RecordTable CreateChildRecordTable(IDbConnection dbConnection, string fileName) {
    return RecordFactory.CreateRecordTable(dbConnection, fileName, this);
  }

  private bool EqualsArray(object[] array) {
    if (array.Length != values.Length) return false;
    for (int i = 0; i < values.Length; i++) {
      if (values[i] == null) {
        if (array[i] != null) return false;
      }
      else {
        if (!values[i].Equals(array[i])) return false;
      }
    }
    return true;
  }

  public override int GetHashCode() {
    int ret = 0;
    for (int i = 0; i < values.Length; i++) {
      if (values[i] != null) ret += values[i].GetHashCode();
    }
    return ret;
  }
  
  public override bool Equals(object val) {
    object[] array = val as object[];
    if (array != null) return EqualsArray(array);
    
    Record rec = val as Record;
    if (rec != null) return EqualsArray(rec.values);
    
    return false;
  }

  public bool EqualsPKey(object val) {
    object[] array = val as object[];
    string[] pkNamesArray = recordInfo.GetPKeysNamesArray();

    if (array != null) {
      if (array.Length != pkNamesArray.Length) return false;
      for (int i = 0; i < pkNamesArray.Length; i++) {
        object o = GetValue(pkNamesArray[i]);
        if (o == null) {
          if (array[i] != null) return false;
        }
        else {
          if (!o.Equals(array[i])) return false;
        }
      }
      return true;
    }
    
    Record rec = val as Record;
    if (rec != null) {
      for (int i = 0; i < pkNamesArray.Length; i++) {
        if (!rec.RecordInfo.Fields.Contains(pkNamesArray[i])) return false;
        object o1 = GetValue(pkNamesArray[i]);
        object o2 = rec.GetValue(pkNamesArray[i]);
        if (o1 == null) {
          if (o2 != null) return false;
        }
        else {
          if (!o1.Equals(o2)) return false;
        }
      }
      return true;
    }
    
    return false;
  }

  public string GetString(string column) {
    return DataConverter.ToString(GetValue(column));
  }

  public string GetString(int column) {
    return DataConverter.ToString(GetValue(column));
  }

  public string GetString(string column, CultureInfo cultureInfo) {
    return DataConverter.ToString(GetValue(column), cultureInfo);
  }

  public string GetString(int column, CultureInfo cultureInfo) {
    return DataConverter.ToString(GetValue(column), cultureInfo);
  }

  public int GetInt(int column) {
    if (recordInfo.Fields[column].DbType != DbType.Int32) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");
    return (int) val;
  }

  public int GetInt(string column) {
    return GetInt(recordInfo.GetFieldIndex(column));
  }
  
  public int GetInt(int column, int defaultValue) {
    if (recordInfo.Fields[column].DbType != DbType.Int32) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    return (val == null) ? defaultValue : (int) val;
  }

  public int GetInt(string column, int defaultValue) {
    return GetInt(recordInfo.GetFieldIndex(column), defaultValue);
  }
  
  public bool GetBool(int column) {
    if (recordInfo.Fields[column].DbType != DbType.Boolean) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    if (val == null) throw new ModelException(recordInfo, column, "null value");
    return (bool) val;
  }

  public bool GetBool(string column) {
    return GetBool(recordInfo.GetFieldIndex(column));
  }

  public bool GetBool(int column, bool defaultValue) {
    if (recordInfo.Fields[column].DbType != DbType.Boolean) throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    return (val == null) ? defaultValue : (bool) val;
  }

  public bool GetBool(string column, bool defaultValue) {
    return GetBool(recordInfo.GetFieldIndex(column), defaultValue);
  }

  public DateTime GetDateTime(int column) {
    if ((recordInfo.Fields[column].DbType != DbType.DateTime)
        && (recordInfo.Fields[column].DbType != DbType.Date)
        && (recordInfo.Fields[column].DbType != DbType.Time))
      throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    return (DateTime) val;
  }

  public DateTime GetDateTime(string column) {
    return GetDateTime(recordInfo.GetFieldIndex(column));
  }

  public DateTime GetDate(int column) {
    if ((recordInfo.Fields[column].DbType != DbType.DateTime)
        && (recordInfo.Fields[column].DbType != DbType.Date))
      throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    return ((DateTime) val).Date;
  }

  public DateTime GetDate(string column) {
    return GetDate(recordInfo.GetFieldIndex(column));
  }

  public TimeSpan GetTime(int column) {
    if ((recordInfo.Fields[column].DbType != DbType.DateTime)
        && (recordInfo.Fields[column].DbType != DbType.Time))
      throw new ModelException(recordInfo, column, "wrong datatype");
    object val = GetValue(column);
    return ((DateTime) val).TimeOfDay;
  }

  public TimeSpan GetTime(string column) {
    return GetTime(recordInfo.GetFieldIndex(column));
  }

}


} // namespace

