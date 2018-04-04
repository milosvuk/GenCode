using System;
using System.Data;
using System.Globalization;
using Greco.View;
using Greco.Util;

namespace Greco.Model {
/// <summary>
/// Description résumée de RelationInfo.
/// </summary>
public class RelationInfo {
  private RecordInfo recordInfo1, recordInfo2;
  private string[] fields1, fields2, params1, params2, staticParams2;
  private object[] staticParams1;
  private bool hasParameters, isEnumeration, alwaysRefresh, isNullable;
  private string referencedValueField, referencedDisplayField;
  private RecordTable referencedRecordTable;

  public RelationInfo(RecordInfo recordInfo1, RecordInfo recordInfo2,
                      string[] fields1, string[] fields2,
                      string[] params1, string[] params2,
                      object[] staticParams1, string[] staticParams2,
                      string displayField) {
    if (fields1.Length != fields2.Length)
      throw new ModelException(recordInfo1, "Field counts don't match for relation info " + recordInfo2);

    // TODO : pour l'instant qu'une seule colonne, faudrait rajouter une colonne RecordID ou concaténer les clés primaires
    // Dans ListControl il y a DataValueField qui est de type string
    if (fields1.Length != 1)
      throw new ModelException(recordInfo1, "Multiple RelationInfo fields not yet implemented");
    this.referencedValueField = fields2[0];

    this.recordInfo1 = recordInfo1;
    this.recordInfo2 = recordInfo2;   
    this.fields1 = fields1;
    this.fields2 = fields2;
    
    hasParameters = false;
    this.params1 = params1;
    this.params2 = params2;
    if (params1 != null) {
      if ((params2 == null) || (params1.Length != params2.Length))
        throw new ModelException(recordInfo1, "Parameter counts don't match for relation info " + recordInfo2);
      if (recordInfo2.ParametersInfo == null)
        throw new ModelException(recordInfo1, recordInfo2 + " has no parameters");
      hasParameters = true;
    }

    this.staticParams1 = staticParams1;
    this.staticParams2 = staticParams2;
    if (staticParams1 != null) {
      if ((staticParams2 == null) || (staticParams1.Length != staticParams2.Length))
        throw new ModelException(recordInfo1, "Static parameter counts don't match for relation info " + recordInfo2);
      if (recordInfo2.ParametersInfo == null)
        throw new ModelException(recordInfo1, recordInfo2 + " has no parameters");
      hasParameters = true;
    }

    isEnumeration = (fields1.Length == 1) && (params1 == null);
    alwaysRefresh = (params1 != null);

    if (displayField != null) this.referencedDisplayField = displayField;
    else {
      // TODO : ne pas systématiquement prendre le renderInfo par défaut
      RecordRenderInfo rri2 = recordInfo2.GetRenderInfo();
      for (int i = 0; i < rri2.Fields.Count; i++) {
        if (rri2.Fields[i].ColumnVisible) {
          this.referencedDisplayField = rri2.Fields[i].FieldMetaData.Name;
          break;
        }
      }
    }
    
    isNullable = true;
    for (int i = 0; i < fields1.Length; i++) {
      FieldMetaData fmd = recordInfo1.Fields[fields1[i]];
      fmd.relationInfo = this;
      if (!fmd.Nullable) isNullable = false;
    }
    referencedRecordTable = null;
  }

  public RelationInfo(RecordInfo recordInfo1, RecordInfo recordInfo2,
                      string[] fields1, string[] fields2)
                     : this(recordInfo1, recordInfo2, fields1, fields2,
                            null, null, null, null, null) {
  }

  
  public RecordInfo RecordInfo1 { get { return recordInfo1; } }
  public RecordInfo RecordInfo2 { get { return recordInfo2; } }
  
  public bool Enumeration {
    get { return isEnumeration; }
    set { isEnumeration = value; }
  }
  
  public bool AlwaysRefresh {
    get { return alwaysRefresh; }
    set { alwaysRefresh = value; }
  }
  
  public bool HasParameters {
    get { return hasParameters; }
  }
  
  public string[] Fields {
    get { return fields1; }
  }
  
  public string[] ReferencedFields {
    get { return fields2; }
  }

  public string ReferencedValueField {
    get { return referencedValueField; }
  }

  public string ReferencedDisplayField {
    get { return referencedDisplayField; }
  }

  public bool Nullable {
    get { return isNullable; }
  }

  public RecordTable GetReferencedRecordTable(IDbConnection dbConnection, Record record) {
    if (referencedRecordTable != null) return referencedRecordTable;
    
    Record record2 = null;
    if (recordInfo2.ParametersInfo != null) {
      record2 = new Record(recordInfo2.ParametersInfo);
      if (params2 != null) {
        for (int i = 0; i < params2.Length; i++) {
          object o = record[params1[i]];
          record2[params2[i]] = o;
        }
      }
      if (staticParams2 != null) {
        for (int i = 0; i < staticParams2.Length; i++)
          record2[staticParams2[i]] = staticParams1;
      }
    }
    RecordTable rt = RecordFactory.CreateRecordTable(dbConnection, recordInfo2, record2);
    // TODO : ajouter systématiquement une ligne vide + libellé dépendant du contexte ?
    /*
    if (isNullable || true) {
      Record rec = rt.NewRecord();
      rt.InsertAt(rec, 0);
    }
    */
    if (record2 == null) referencedRecordTable = rt;
    return rt;
  }
  
  private bool RecordEqualsRow(Record rec, RecordTable rt, int row) {
    for (int col = 0; col < fields1.Length; col++) {
      if (rec[fields1[col]] == null) {
        if (rt[row, fields2[col]] != null) return false;
      }
      else {
        if (!rec[fields1[col]].Equals(rt[row, fields2[col]])) return false;
      }
    }
    return true;
  }
  
  public string MakeStringValues(Record rec) {
    // TODO : références avec clés multiples
    object val = rec[fields1[0]];
    return (val != null) ? val.ToString() : null;
  }
  
  public object MakeValues(Record rec) {
    if (fields1.Length == 1) {
      return rec[fields1[0]];
    }
    else {
      return MakeStringValues(rec);
    }
  }
  
  public void SetValues(Record rec, string strValue, bool checkValues) {
    // TODO : références avec clés multiples
    rec.SetValue(fields1[0], strValue, checkValues);
  }

  public string GetDisplayField(RecordRenderInfo rri) {
    string fieldName = fields1[fields1.Length - 1];
    // La colonne affichée. Par défaut, c'est celle indiquée dans la définition de ce RelationInfo
    // mais elle peut être redéfinie au niveau du champ d'origine selon le RenderContext
    string displayField = rri.Fields[fieldName].RelationDisplayField;
    if (displayField == null) displayField = referencedDisplayField;
    return displayField;
  }
  
  public string GetDisplayLabel(IDbConnection dbConnection, Record rec, RecordRenderInfo rri) {
    bool isNull = true;
    for (int col = 0; col < fields1.Length; col++) {
      if (rec[fields1[col]] != null) {
        isNull = false;
        break;
      }
    }
    if (isNull) return null;

    string fieldName = fields1[fields1.Length - 1];
    string displayField = GetDisplayField(rri);
    
    RecordTable rt = GetReferencedRecordTable(dbConnection, rec);
    for (int row = 0; row < rt.Count; row++) {
      if (RecordEqualsRow(rec, rt, row)) {
        return rt.GetStringAt(row, displayField, rri.SafeCultureInfo);
      }
    }
    // pas trouvé la valeur dans RT, on affiche rec
    Log.Error("Referenced value not found for " + rec);
    return rec.GetString(fieldName, rri.SafeCultureInfo);
  }
}


} // namespace
