// DataConverter.cs
//
using System;
using System.Data;
using System.Globalization;
using Greco.Util;
using Greco.View;

namespace Greco.Model {

/// <summary>
/// Summary description for DataConverter.
/// </summary>
public class DataConverter {
  public static DbType TypeToDbType(Type type) {
    if (type == System.Type.GetType("System.Boolean")) return DbType.Boolean;
    else if (type == System.Type.GetType("System.Byte")) return DbType.Byte;
    else if (type == System.Type.GetType("System.Char")) return DbType.String;
    else if (type == System.Type.GetType("System.DateTime")) return DbType.DateTime;
    else if (type == System.Type.GetType("System.Decimal")) return DbType.Decimal;
    else if (type == System.Type.GetType("System.Double")) return DbType.Double;
    else if (type == System.Type.GetType("System.Int16")) return DbType.Int16;
    else if (type == System.Type.GetType("System.Int32")) return DbType.Int32;
    else if (type == System.Type.GetType("System.Int64")) return DbType.Int64;
    else if (type == System.Type.GetType("System.SByte")) return DbType.SByte;
    else if (type == System.Type.GetType("System.Single")) return DbType.Single;
    else if (type == System.Type.GetType("System.String")) return DbType.String;
    else if (type == System.Type.GetType("System.TimeSpan")) return DbType.Time;
    else if (type == System.Type.GetType("System.Single")) return DbType.Single;
    else if (type == System.Type.GetType("System.UInt16")) return DbType.UInt16;
    else if (type == System.Type.GetType("System.UInt32")) return DbType.UInt32;
    else if (type == System.Type.GetType("System.UInt64")) return DbType.UInt64;
    else return DbType.Object;
  }


  public static Type DbTypeToType(DbType dbType) {
    if (dbType == DbType.Boolean) return System.Type.GetType("System.Boolean");
    else if (dbType == DbType.Byte) return System.Type.GetType("System.Byte");
    else if (dbType == DbType.StringFixedLength) return System.Type.GetType("System.String");
    else if (dbType == DbType.DateTime) return System.Type.GetType("System.DateTime");
    else if (dbType == DbType.Decimal) return System.Type.GetType("System.Decimal");
    else if (dbType == DbType.Double) return System.Type.GetType("System.Double");
    else if (dbType == DbType.Int16) return System.Type.GetType("System.Int16");
    else if (dbType == DbType.Int32) return System.Type.GetType("System.Int32");
    else if (dbType == DbType.Int64) return System.Type.GetType("System.Int64");
    else if (dbType == DbType.SByte) return System.Type.GetType("System.SByte");
    else if (dbType == DbType.Single) return System.Type.GetType("System.Single");
    else if (dbType == DbType.String) return System.Type.GetType("System.String");
    else if (dbType == DbType.Object) return System.Type.GetType("System.TimeSpan");
    else if (dbType == DbType.Single) return System.Type.GetType("System.Single");
    else if (dbType == DbType.UInt16) return System.Type.GetType("System.UInt16");
    else if (dbType == DbType.UInt32) return System.Type.GetType("System.UInt32");
    else if (dbType == DbType.UInt64) return System.Type.GetType("System.UInt64");
    // DbType qu'on ne retrouve pas dans l'autre sens
    else if (dbType == DbType.AnsiString) return System.Type.GetType("System.String");
    else if (dbType == DbType.AnsiStringFixedLength) return System.Type.GetType("System.String");
    else if (dbType == DbType.Binary) return System.Type.GetType("System.Object");
    else if (dbType == DbType.Currency) return System.Type.GetType("System.Decimal");
    else if (dbType == DbType.Date) return System.Type.GetType("System.DateTime");
    else if (dbType == DbType.Guid) return System.Type.GetType("System.Object");
    else if (dbType == DbType.StringFixedLength) return System.Type.GetType("System.String");
    else if (dbType == DbType.Time) return System.Type.GetType("System.TimeSpan");
    else if (dbType == DbType.VarNumeric) return System.Type.GetType("System.UInt64");
    else return System.Type.GetType("System.Object");
  }

  public static bool ToBool(string s) {
    if (s == null) return false;
    s = s.ToLower();
    return s.StartsWith("o") || s.StartsWith("y") || s.StartsWith("1") || s.Equals("true");
  }

  public static object ConvertValue(object val, Type type) {
    return ConvertValue(val, type, null);
  }

  public static object ConvertValue(object val, Type type, CultureInfo cultureInfo) {
    if ((val == null) || Convert.DBNull.Equals(val)) return null;
    if (val.GetType().Equals(type)) {
      if (val.GetType().Equals(System.Type.GetType("System.String"))) {
        string s2 = val as string;
        if (s2.Length == 0) return null;
      }
      else return val;
    }
    
    return ConvertValue(val, TypeToDbType(type), cultureInfo);
  }

  public static object ConvertValue(object val, DbType dbType) {
    return ConvertValue(val, dbType, null);
  }

  public static object ConvertValue(object val, DbType dbType, CultureInfo cultureInfo) {
    if ((val == null) || Convert.DBNull.Equals(val)) return null;
    if (val.GetType().Equals(DbTypeToType(dbType))) {
      if (val.GetType().Equals(System.Type.GetType("System.String"))) {
        string s2 = val as string;
        if (s2.Length == 0) return null;
      }
      else return val;
    }
    
    // on essaye de faire une conversion à partir d'un texte
    string s = val as string;
    if (s != null) {
      s = (string) val;
      if (s.Length == 0) return null;
      if (cultureInfo == null) cultureInfo = ApplicationConfig.DefaultCultureInfo;
      try {
        switch (dbType) {
          case DbType.StringFixedLength:
          case DbType.String:
          case DbType.AnsiString:
          case DbType.AnsiStringFixedLength:
            return s;
          case DbType.Boolean:
            return ToBool(s);
          case DbType.Byte:
            return Byte.Parse(s, cultureInfo);
          case DbType.Date:
            DateTime dt = DateTime.Parse(s, cultureInfo);
            return new DateTime(dt.Year, dt.Month, dt.Day);
          case DbType.DateTime:
            return DateTime.Parse(s, cultureInfo);
          case DbType.Time:
            return DateTime.Parse(s, cultureInfo).TimeOfDay;
          case DbType.Decimal:
          case DbType.Currency:
            return Decimal.Parse(s, cultureInfo);
          case DbType.Double:
            return Double.Parse(s, cultureInfo);
          case DbType.Int16:
            return Int16.Parse(s, cultureInfo);
          case DbType.Int32:
            return Int32.Parse(s, cultureInfo);
          case DbType.Int64:
          case DbType.VarNumeric:
            return Int64.Parse(s, cultureInfo);
          case DbType.SByte:
            return SByte.Parse(s, cultureInfo);
          case DbType.UInt16:
            return UInt16.Parse(s, cultureInfo);
          case DbType.UInt32:
            return UInt32.Parse(s, cultureInfo);
          case DbType.UInt64:
            return UInt64.Parse(s, cultureInfo);
        }
      }
      catch (FormatException exc) {
        Log.Error("Error parsing " + s + " : " + exc.Message);
        throw;
      }
    }
    
    // on a un objet qu'on va essayer de convertir en string ou en bool
    switch (dbType) {
      case DbType.StringFixedLength:
      case DbType.String:
      case DbType.AnsiString:
      case DbType.AnsiStringFixedLength:
        if (cultureInfo == null) cultureInfo = ApplicationConfig.DefaultCultureInfo;
        return Convert.ToString(val, cultureInfo);
      case DbType.Boolean:
        return Convert.ToBoolean(val);
      case DbType.Int16:
        return Convert.ToInt16(val);
      case DbType.Int32:
        return Convert.ToInt32(val);
      case DbType.Int64:
        return Convert.ToInt64(val);
      // TODO : date
      default:
        throw new UserInputException(val.ToString());
    }
  }
  
  public static string ToString(object val, CultureInfo cultureInfo) {
    if ((val == null) || DBNull.Value.Equals(val)) return null;
    string s = val as string;
    if (s != null) return s;
    else return Convert.ToString(val, cultureInfo);
  }
  
  public static string ToString(object val) {
    return ToString(val, null);
  }

  public static object ToEnum(string val, Type enumType, bool caseSensitive, object defaultValue) {
    return ToEnum(val, enumType, caseSensitive, false, defaultValue);
  }
  
  public static object ToEnum(string val, Type enumType, object defaultValue) {
    return ToEnum(val, enumType, false, false, defaultValue);
  }
  
  public static object ToEnum(string val, Type enumType, bool caseSensitive, bool throwException) {
    return ToEnum(val, enumType, caseSensitive, throwException, null);
  }
  
  public static object ToEnum(string val, Type enumType,
                              bool caseSensitive, bool throwException,
                              object defaultValue) {
    if (val == null) return defaultValue;
    if (caseSensitive) {
      try {
        return Enum.Parse(enumType, val);
      }
      catch (Exception ) {
        if (throwException) throw;
        else return defaultValue;
      }
    }
    else {
      val = val.ToLower();
      foreach (string name in Enum.GetNames(enumType)) {
        if (val.Equals(name.ToLower())) return Enum.Parse(enumType, name);
      }
      if (!throwException) return defaultValue;
      throw new ResourceParseException(enumType.ToString() + " : enumeration value not found for " + val);
    }
  }
}


} // namespace
