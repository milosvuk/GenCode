// FieldMetaData.cs
//
using System;
using System.Data;
using System.Globalization;

namespace Greco.Model {

/// <summary>
/// Summary description for FieldMetaData.
/// </summary>
public class FieldMetaData : ICloneable {
  protected string name, domain;
  protected DbType dbType;
  protected int length, precision;
  protected bool isPrimaryKey, isUnique, isNullable, isExternal;
  protected object defaultValue, minValue, maxValue;
  protected string adoExpression, regularExpression;
  internal RelationInfo relationInfo;

  /// <summary>
  /// Creates a new instance of FieldMetaData
  /// </summary>
  public FieldMetaData(string name, DbType dbType, int length, int precision) {
    this.name = name;
    this.dbType = dbType;
    this.length = length;
    this.precision = precision;
    isPrimaryKey = false;
    isUnique = false;
    isNullable = true;
    isExternal = false;
    defaultValue = null;
    minValue = null;
    maxValue = null;
    domain = null;
    relationInfo = null;
  }


  public FieldMetaData(string name, string domain) {
    this.name = name;
    FieldMetaData fmd = RecordInfoFactory.GetDomainFieldMetaData(domain);
    if (fmd == null) throw new DomainNotFoundException(domain);
    this.dbType = fmd.dbType;
    this.length = fmd.length;
    this.precision = fmd.precision;
    fmd.copyTo(this);
    this.domain = domain;
    relationInfo = null;
  }


  public FieldMetaData(string name, DbType dbType, int length)
         : this(name, dbType, length, -1) {
  }

  public FieldMetaData(string name, DbType dbType)
         : this(name, dbType, -1, -1) {
  }

  public string Name {
    get { return name; }
  }

  public DbType DbType {
    get { return dbType; }
  }
  
  public Type InternalType {
    get { return DataConverter.DbTypeToType(dbType); }
  }

  public int Length {
    get { return length; }
  }

  public int Precision {
    get { return precision; }
  }

  public string Domain {
    get { return domain; }
  }

  public bool PrimaryKey {
    get { return isPrimaryKey; }
    set { isPrimaryKey = value; }
  }

  public bool Unique {
    get { return isUnique; }
    set { isUnique = value; }
  }

  public bool Nullable {
    get { return isNullable; }
    set { isNullable = value; }
  }

  public bool External {
    get { return isExternal; }
    set { isExternal = value; }
  }

  public bool HasRelation {
    get { return (relationInfo != null); }
  }
  
  public RelationInfo RelationInfo {
    get { return relationInfo; }
  }

  public object DefaultValue {
    get { return defaultValue; }
    set { defaultValue = value; }
  }

  public object MinValue {
    get { return minValue; }
    set { minValue = value; }
  }

  public object MaxValue {
    get { return maxValue; }
    set { maxValue = value; }
  }

  public string AdoExpression {
    get { return adoExpression; }
    set { adoExpression = value; }
  }

  public string RegularExpression {
    get { return regularExpression; }
    set { regularExpression = value; }
  }

  public object Validate(object val, bool checkValue, CultureInfo cultureInfo) {
    object o;
    try {
      o = DataConverter.ConvertValue(val, dbType, cultureInfo);
    }
    catch (UserInputException) {
      throw new UserInputException(this, val);
    }
    if (checkValue) {
      if (!isNullable && (o == null)) throw new FieldNotNullableException(this);
    }
    // TODO : implémenter vérifications longueur et min-max (size < 0 : pas de vérif)
    // Pour le moment, ça repose sur le dataRow
    return o;
  }

  public object Validate(object val, bool checkValue) {
    return Validate(val, checkValue, null);
  }
  
  public object Validate(object val, CultureInfo cultureInfo) {
    return Validate(val, true, cultureInfo);
  }

  public object Validate(object val) {
    return Validate(val, true, null);
  }

  public void copyTo(FieldMetaData fmd) {
    fmd.isPrimaryKey = isPrimaryKey;
    fmd.isUnique = isUnique;
    fmd.isNullable = isNullable;
    fmd.isExternal = isExternal;
    fmd.defaultValue = defaultValue;
    fmd.minValue = minValue;
    fmd.maxValue = maxValue;
    fmd.adoExpression = adoExpression;
    fmd.regularExpression = regularExpression;
  }

  public object Clone() {
    FieldMetaData fmd = new FieldMetaData(name, dbType, length, precision);
    copyTo(fmd);
    return fmd;
  }

  public override string ToString() {
    return name;
  }

}


} // namespace

