using System;
using System.Collections;
using System.Data;
using Greco.Util;
using Greco.View;

namespace Greco.Model {

/// <summary>
/// Description résumée de RecordInfo.
/// </summary>
public class RecordInfo : RecordMetaData {
  protected RecordRenderInfo defaultRenderInfo;
  protected Hashtable renderInfos;
  protected RecordInfo parametersInfo;
  internal bool parsingDone, autoLoad, autoColumns;
  protected RecordTable staticRecordTable;
  protected ArrayList relationsInfos;
  internal bool isParameter;
  internal string parentModule;
  internal string[] parentColumns, childColumns;

  public RecordInfo(string name, bool lowerNames) : base(name, lowerNames) {
    defaultRenderInfo = null;
    renderInfos = new Hashtable();
    parametersInfo = null;
    parsingDone = false;
    autoLoad = autoColumns = true;
    staticRecordTable = null;
    relationsInfos = new ArrayList();
    isParameter = false;
    parentModule = null;
  }

  public RecordInfo(string name) : this(name, true) { }

  public RecordInfo(DataTable dataTable, bool lowerNames) : base(dataTable, lowerNames) {
    defaultRenderInfo = null;
    renderInfos = new Hashtable();
    parametersInfo = null;
    parsingDone = false;
    autoLoad = autoColumns = true;
    staticRecordTable = null;
    isParameter = false;
  }

  public RecordInfo(DataTable dataTable) : this(dataTable, true) { }

  public RecordRenderInfo GetRenderInfo(bool createIfNotExists) {
    if ((defaultRenderInfo == null) && createIfNotExists)
      defaultRenderInfo = new RecordRenderInfo(this);
    return defaultRenderInfo;
  }

  public RecordRenderInfo GetRenderInfo() {
    return GetRenderInfo(true);
  }

  public RecordRenderInfo GetRenderInfo(RenderContext renderContext) {
    return GetRenderInfo(renderContext, false);
  }

  public RecordRenderInfo GetRenderInfo(RenderContext renderContext, bool createIfNotExists) {
    if (renderContext == null) {
      return GetRenderInfo(true);
    }
    else if (renderInfos.Contains(renderContext)) {
      return (RecordRenderInfo) renderInfos[renderContext];
    }
    else if (createIfNotExists) {
      // on crée un nouveau à partir de celui qui s'en rapproche le plus
      RecordRenderInfo sourceRenderInfo = GetSimilarRenderInfo(renderContext);
      if (sourceRenderInfo == null) sourceRenderInfo = GetRenderInfo(true);
      RecordRenderInfo renderInfo = (RecordRenderInfo) sourceRenderInfo.Clone();
      renderInfo.renderContext = renderContext;
      renderInfos.Add(renderContext, renderInfo);
      return renderInfo;
    }
    else {
      // on renvoie un renderInfo approchant ou celui par défaut
      RecordRenderInfo renderInfo = GetSimilarRenderInfo(renderContext);
      return (renderInfo != null) ? renderInfo : defaultRenderInfo;
    }
  }
  
  protected RecordRenderInfo GetSimilarRenderInfo(RenderContext renderContext) {
    RenderContext renderContext2 = RenderContext.GetSimilarRenderContext(renderInfos, renderContext);
    return (renderContext2 != null) ? (RecordRenderInfo) renderInfos[renderContext2] : null;    
  }

  public override DataTable CreateDataTable() {
    DataTable dataTable = base.CreateDataTable();

    if (defaultRenderInfo != null) {
      foreach (FieldRenderInfo field in defaultRenderInfo.Fields) {
        if (dataTable.Columns.Contains(field.FieldMetaData.Name)) {
          DataColumn dataColumn = dataTable.Columns[field.FieldMetaData.Name];
          dataColumn.Caption = field.Label;
        }
      }
    }
    return dataTable;
  }

  public RecordInfo ParametersInfo {
    get { return parametersInfo; }
    set { parametersInfo = value; }
  }
  
  public RecordTable StaticRecordTable {
    get { return staticRecordTable; }
    set { staticRecordTable = value; }
  }
  
  public ArrayList RelationsInfos {
    get { return relationsInfos; }
  }

  // WARNING : ça ne prend que le 1er, les relations doivent donc être déclarées dans le bon ordre  
  public RelationInfo GetRelationInfo(string fieldName) {
    if (configDictionary.LowerKeys) fieldName = fieldName.ToLower();
    for (int i = 0; i < relationsInfos.Count; i++) {
      RelationInfo relationInfo = (RelationInfo) relationsInfos[i];
      for (int j = 0; j < relationInfo.Fields.Length; j++)
        if (relationInfo.Fields[j].Equals(fieldName)) return relationInfo;
    }
    return null;
  }
  
  public bool IsPersistent {
    get { return (staticRecordTable == null); }
  }
  
  public bool IsParameter {
    get { return isParameter; }
  }

  public string ParentModule {
    get { return parentModule; }
  }

  public string[] ParentColumns {
    get { return parentColumns; }
  }

  public string[] ChildColumns {
    get { return childColumns; }
  }

}


} // namespace
