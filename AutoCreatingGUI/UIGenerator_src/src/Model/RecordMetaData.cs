// RecordMetaData.cs
//

using System;
using System.Data;
using Greco.Util;

namespace Greco.Model {

/// <summary>
/// Summary description for RecordMetaData.
/// </summary>
public class RecordMetaData {
  protected string name, tableName, sequence;
  protected FieldMetaDataCollection fields;
  protected string sqlSelectText, sqlSelectOneText,
                   sqlInsertText, sqlUpdateText, sqlDeleteText,
                   sqlSelectBeforeInsertText, sqlSelectAfterInsertText,
                   sqlSelectBeforeUpdateText, sqlSelectAfterUpdateText,
                   sqlCheckBeforeDeleteText;
  protected CommandType sqlSelectType, sqlInsertType, sqlUpdateType, sqlDeleteType,
                        sqlSelectBeforeInsertType, sqlSelectAfterInsertType,
                        sqlSelectBeforeUpdateType, sqlSelectAfterUpdateType,
                        sqlCheckBeforeDeleteType;
  internal bool lowerNames;
  protected ConfigDictionary configDictionary;
  protected string[] nameArray, pkNameArray;

  /// <summary>
  /// Creates a new instance of RecordMetaData
  /// </summary>
  public RecordMetaData(string name, bool lowerNames) {
    this.name = name;
    this.lowerNames = lowerNames;
    fields = new FieldMetaDataCollection(this);
    nameArray = pkNameArray = null;
  }

  public RecordMetaData(string name) : this(name, true) { }

  public RecordMetaData(DataTable dataTable, bool lowerNames) {
    this.name = dataTable.TableName;
    this.lowerNames = lowerNames;
    fields = new FieldMetaDataCollection(this);
    FromDataTable(dataTable);
    nameArray = pkNameArray = null;
  }

  public RecordMetaData(DataTable dataTable) : this(dataTable, true) { }

  public void FromDataTable(DataTable dataTable) {
    DataColumn[] primaryKeys = dataTable.PrimaryKey;
    foreach (DataColumn dataColumn in dataTable.Columns) {
      if (!fields.Contains(dataColumn.ColumnName)) {
        FieldMetaData field = new FieldMetaData(dataColumn.ColumnName,
                                                DataConverter.TypeToDbType(dataColumn.DataType),
                                                dataColumn.MaxLength);
        field.Nullable = dataColumn.AllowDBNull;
        field.Unique = dataColumn.Unique;
        field.DefaultValue = dataColumn.DefaultValue;
        field.AdoExpression = dataColumn.Expression;
        for (int i = 0; i < primaryKeys.Length; i++) {
          if (dataColumn.Equals(primaryKeys[i])) field.PrimaryKey = true;
        }
        fields.Add(field);
      }
    }
  }

  public void FromSchemaTable(DataTable schemaTable) {
    foreach (DataRow dataRow in schemaTable.Rows) {
      string columnName = (string) dataRow["ColumnName"];
      if (lowerNames) columnName = columnName.ToLower();
      Type dataType = (Type) dataRow["DataType"];
      int columnSize = (int) dataRow["ColumnSize"];
      // TODO : dataRow["NumericPrecision / NumericScale"];
      if (!fields.Contains(columnName)) {
        FieldMetaData field = new FieldMetaData(columnName,
                                                DataConverter.TypeToDbType(dataType),
                                                columnSize);
        field.Nullable = (bool) dataRow["AllowDBNull"];
        // TODO : ne marche pas sous Oracle
        //field.Unique = (bool) dataRow["IsUnique"];
        // TODO : dataRow["IsKeyColumn"] ne veut pas forcément dire primary key
        fields.Add(field);        
      }
    }
  }

  /// Pour constructeur de RecordTable
  public virtual DataTable CreateDataTable() {
    DataTable dataTable = new DataTable((tableName != null) ? tableName : name);

    int pkIndex = 0;
    foreach (FieldMetaData field in fields) {
      if (field.PrimaryKey) pkIndex++;
    }
    DataColumn[] primaryKeys = new DataColumn[pkIndex];
    pkIndex = 0;

    foreach (FieldMetaData field in fields) {
      DataColumn dataColumn = new DataColumn(field.Name);
      dataColumn.DataType = DataConverter.DbTypeToType(field.DbType);
      if (dataColumn.DataType == System.Type.GetType("System.String"))
        dataColumn.MaxLength = field.Length;
      dataColumn.AllowDBNull = field.Nullable;
      dataColumn.Unique = field.Unique;
      dataColumn.DefaultValue = field.DefaultValue;
      dataColumn.Expression = field.AdoExpression;
      if (field.PrimaryKey) primaryKeys[pkIndex++] = dataColumn;
      dataTable.Columns.Add(dataColumn);
    }
    dataTable.PrimaryKey = primaryKeys;
    dataTable.CaseSensitive = false;
    return dataTable;
  }

  public string Name {
    get { return name; }
  }

  public string Module {
    get { return name; }
  }

  public string TableName {
    get { return tableName; }
    set { tableName = value; }
  }

  public string Sequence {
    get { return sequence; }
    set { sequence = value; }
  }

  public FieldMetaDataCollection Fields {
    get { return fields; }
  }

  public int GetFieldIndex(string fieldName) {
    return fields.GetFieldIndex(fieldName);
  }

  public bool Contains(string fieldName) {
    return fields.Contains(fieldName);
  }

  public string SqlSelectText {
    get { return sqlSelectText; }
    set { sqlSelectText = value; }
  }

  public string SqlSelectOneText {
    get { return sqlSelectOneText; }
    set { sqlSelectOneText = value; }
  }

  public string SqlInsertText {
    get { return sqlInsertText; }
    set { sqlInsertText = value; }
  }

  public string SqlUpdateText {
    get { return sqlUpdateText; }
    set { sqlUpdateText = value; }
  }

  public string SqlDeleteText {
    get { return sqlDeleteText; }
    set { sqlDeleteText = value; }
  }

  public CommandType SqlSelectType {
    get { return sqlSelectType; }
    set { sqlSelectType = value; }
  }

  public CommandType SqlInsertType {
    get { return sqlInsertType; }
    set { sqlInsertType = value; }
  }

  public CommandType SqlUpdateType {
    get { return sqlUpdateType; }
    set { sqlUpdateType = value; }
  }

  public CommandType SqlDeleteType {
    get { return sqlDeleteType; }
    set { sqlDeleteType = value; }
  }

  public CommandType SqlSelectBeforeInsertType {
    get { return sqlSelectBeforeInsertType; }
    set { sqlSelectBeforeInsertType = value; }
  }

  public CommandType SqlSelectAfterInsertType {
    get { return sqlSelectAfterInsertType; }
    set { sqlSelectAfterInsertType = value; }
  }

  public CommandType SqlSelectBeforeUpdateType {
    get { return sqlSelectBeforeUpdateType; }
    set { sqlSelectBeforeUpdateType = value; }
  }

  public CommandType SqlSelectAfterUpdateType {
    get { return sqlSelectAfterUpdateType; }
    set { sqlSelectAfterUpdateType = value; }
  }

  public CommandType SqlCheckBeforeDeleteType {
    get { return sqlCheckBeforeDeleteType; }
    set { sqlCheckBeforeDeleteType = value; }
  }

  public string SqlSelectBeforeInsertText {
    get { return sqlSelectBeforeInsertText; }
    set { sqlSelectBeforeInsertText = value; }
  }

  public string SqlSelectAfterInsertText {
    get { return sqlSelectAfterInsertText; }
    set { sqlSelectAfterInsertText = value; }
  }

  public string SqlSelectBeforeUpdateText {
    get { return sqlSelectBeforeUpdateText; }
    set { sqlSelectBeforeUpdateText = value; }
  }

  public string SqlSelectAfterUpdateText {
    get { return sqlSelectAfterUpdateText; }
    set { sqlSelectAfterUpdateText = value; }
  }

  public string SqlCheckBeforeDeleteText {
    get { return sqlCheckBeforeDeleteText; }
    set { sqlCheckBeforeDeleteText = value; }
  }

  public ConfigDictionary ConfigDictionary {
    get { return configDictionary; }
    set { configDictionary = value; }
  }

  public override string ToString() {
    /* Code à réactiver si debug
    string s = "RecordMetaData " + name + ", " + fields.Count + " fields\n";
    foreach (FieldMetaData field in fields) {
      s += field.Name + " : type = " + field.DbType + "\n";
    }
    return s;
    */
    return name;
  }

  public string[] GetFieldNamesArray() {
    if (nameArray == null) {
      nameArray = new string[fields.Count];
      for (int i = 0; i < fields.Count; i++) nameArray[i] = fields[i].Name;
    }
    return nameArray;
  }

  public string[] GetPKeysNamesArray() {
    if (pkNameArray == null) {
      int n = 0;
      for (int i = 0; i < fields.Count; i++) if (fields[i].PrimaryKey) n++;
      pkNameArray = new string[n];
      n = 0;
      for (int i = 0; i < fields.Count; i++) if (fields[i].PrimaryKey) pkNameArray[n++] = fields[i].Name;
    }
    return pkNameArray;
  }
  
  public int GetPKeyCount() {
    return GetPKeysNamesArray().Length;
  }
}


} // namespace

