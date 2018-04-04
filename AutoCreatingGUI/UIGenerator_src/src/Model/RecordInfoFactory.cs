using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;
using Greco.Util;
using Greco.View;

namespace Greco.Model {

/// <summary>
/// Description résumée de RecordInfoFactory.
/// </summary>
public class RecordInfoFactory {
  public static string VALUES_KEY = "values";
  public static string VALUES_INDEX_KEY = "val";
  protected static RecordInfoFactory instance = null;
  protected ConfigReader configReader;
  protected IConfigParser configParser;
  protected RecordInfoParser recordInfoParser;
  protected RecordInfo domainInfo;

  public static RecordInfoFactory GetInstance() {
    if (instance == null) throw new InitException("RecordInfoFactory not initialized");
    return instance;
  }

  public static void Init(string basePath, string baseResourcePath, string domainFile,
                          string tableRenderFile, string columnRenderFile, string resourceSuffix) {
    if (instance == null) {
      instance = new RecordInfoFactory(basePath, baseResourcePath, domainFile,
                                       tableRenderFile, columnRenderFile, resourceSuffix);
    }
    else throw new InitException("RecordInfoFactory already initialized");
  }

  private RecordInfoFactory(string basePath, string baseResourcePath, string domainFile,
                            string tableRenderFile, string columnRenderFile, string resourceSuffix) {
    configReader = new ConfigReader(basePath, baseResourcePath, resourceSuffix);
    configParser = new DefaultConfigParser(configReader);
    configParser.AddIndexKey(VALUES_KEY, VALUES_INDEX_KEY);
    recordInfoParser = new RecordInfoParser(configParser);
    
    // initialisation de ces variables car elles sont utilisées pour le propre parsing de domainInfo
    instance = this;
    domainInfo = null;
    RecordInfo propsInfo = CreateRecordInfoImpl(tableRenderFile, true, false);
    RecordRenderInfo.Init(propsInfo);
    propsInfo = CreateRecordInfoImpl(columnRenderFile, true, false);
    FieldRenderInfo.Init(propsInfo);

    domainInfo = (domainFile == null) ? null : CreateRecordInfoImpl(domainFile, true);
  }

  public static RecordInfo CreateRecordInfo(string fileName, bool parseColumns, bool parseRender) {
    return instance.CreateRecordInfoImpl(fileName, parseColumns, parseRender);
  }

  public static RecordInfo CreateRecordInfo(string fileName, bool parseColumns) {
    return instance.CreateRecordInfoImpl(fileName, parseColumns);
  }

  public static RecordInfo CreateRecordInfo(string fileName) {
    return CreateRecordInfo(fileName, true);
  }

  public static Record CreateRecord(string fileName, bool parseColumns) {
    RecordInfo ri = CreateRecordInfo(fileName, parseColumns);
    return new Record(ri);
  }

  public static Record CreateRecord(string fileName) {
    return CreateRecord(fileName, true);
  }

  public static RecordTable CreateRecordTable(string fileName, bool parseColumns) {
    RecordInfo ri = CreateRecordInfo(fileName, parseColumns);
    RecordTable rt = (ri.StaticRecordTable != null) ? ri.StaticRecordTable : new RecordTable(ri);
    return rt;
  }

  public static RecordTable CreateRecordTable(string fileName) {
    return CreateRecordTable(fileName, true);
  }

  public static bool DomainExists(string name) {
    if (instance.domainInfo == null) return false;
    return instance.domainInfo.Contains(name);

  }

  public static FieldMetaData GetDomainFieldMetaData(string name, bool clone) {
    return instance.GetDomainFieldMetaDataImpl(name, clone);
  }

  public static FieldMetaData GetDomainFieldMetaData(string name) {
    return instance.GetDomainFieldMetaDataImpl(name, true);
  }
  
  public static FieldRenderInfo GetDomainFieldRenderInfo(string name, RenderContext renderContext,
                                                         bool clone) {
    return instance.GetDomainFieldRenderInfoImpl(name, renderContext, clone);
  }

  public static FieldRenderInfo GetDomainFieldRenderInfo(string name, RenderContext renderContext) {
    return instance.GetDomainFieldRenderInfoImpl(name, renderContext, true);
  }

  public IConfigParser ConfigParser {
    get { return configParser; }
  }

  public string BasePath {
    get { return configReader.BasePath; }
  }

  public RecordInfoParser RecordInfoParser {
    get { return recordInfoParser; }
  }

  public RecordInfo DomainInfo {
    get { return domainInfo; }
  }

  public RecordInfo CreateRecordInfoImpl(string fileName, bool parseColumns) {
    return CreateRecordInfoImpl(fileName, parseColumns, true);
  }

  public RecordInfo CreateRecordInfoImpl(string fileName, bool parseColumns, bool parseRender) {
    if ((fileName == null) || (fileName.Length == 0)) throw new ConfigException("Cannot load RecordInfo with null filename");
    ConfigDictionary cfgDict = new ConfigDictionary(fileName);
    configParser.Parse(fileName, cfgDict);
    RecordInfo recordInfo = new RecordInfo(fileName);
    recordInfo.ConfigDictionary = cfgDict;
    recordInfoParser.Parse1(recordInfo);

    if (parseColumns || recordInfoParser.HasStaticValues(recordInfo)) {
      recordInfoParser.Parse2(recordInfo);
      if (parseRender) recordInfoParser.Parse3(recordInfo);
      recordInfo.parsingDone = true;
    }

    return recordInfo;
  }
  
  public FieldMetaData GetDomainFieldMetaDataImpl(string name, bool clone) {
    if (domainInfo == null) return null;
    if (!domainInfo.Contains(name)) return null;
    FieldMetaData fmd = domainInfo.Fields[name];
    return clone ? (FieldMetaData) fmd.Clone() : fmd;
  }
  
  public FieldRenderInfo GetDomainFieldRenderInfoImpl(string name, RenderContext renderContext,
                                                      bool clone) {
    if (domainInfo == null) return null;
    if (!domainInfo.Contains(name)) return null;
    RecordRenderInfo rri = domainInfo.GetRenderInfo(renderContext, false);
    // ne devrait pas arriver mais on sait jamais
    if (rri == null) return null;
    if (!rri.Fields.Contains(name)) return null;
    FieldRenderInfo fri = rri.Fields[name];
    return clone ? (FieldRenderInfo) fri.Clone() : fri;
  }
}


} // namespace
