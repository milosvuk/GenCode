using System;

namespace Greco.Model {

public class InitException : SystemException {
  public InitException() : base() { }
  public InitException(string message) : base(message) { }
}

public class DbException : SystemException {
  public DbException() : base() { }
  public DbException(string message) : base(message) { }
}

public class DbForeignKeyException : DbException {
  public DbForeignKeyException() : base() { }
  public DbForeignKeyException(string message) : base(message) { }
}

public class ModelException : SystemException {
  protected RecordMetaData recordMetaData;
  protected string fieldName, message;

  public ModelException(RecordMetaData recordMetaData, string fieldName, string message) {
    this.recordMetaData = recordMetaData;
    this.fieldName = fieldName;
    this.message = message;
  }

  public ModelException(RecordMetaData recordMetaData, int fieldNumber, string message) {
    this.recordMetaData = recordMetaData;
    this.fieldName = "field " + fieldNumber;
    this.message = message;
  }

  public ModelException(RecordMetaData recordMetaData, string message)
                         : this(recordMetaData, null, message) { }

  public override string Message {
    get {
      string s = recordMetaData.Name;
      if (fieldName != null) s += "." + fieldName;
      s += " : " + message;
      return s;
    }
  }
}

public class FieldNotFoundException : ModelException {
  private string unknownFieldName;

  public FieldNotFoundException(RecordMetaData recordMetaData, string unknownFieldName)
         : base(recordMetaData, null) {
    this.unknownFieldName = unknownFieldName;
  }

  public string FieldName {
    get { return unknownFieldName; }
  }
  public override string Message {
    get { return "Field '" + unknownFieldName + "' not found in record " + recordMetaData.Name; }
  }
}

public class DomainNotFoundException : SystemException {
  protected string domain;

  public DomainNotFoundException(string domain) {
    this.domain = domain;
  }

  public override string Message {
    get { return "Domain " + domain + " not found"; }
  }
}

public class ResourceParseException : SystemException {
  public ResourceParseException(string message) : base(message) { }
}

public class ConfigException : SystemException {
  public ConfigException(string message) : base(message) { }
}

public class BusinessException : Exception {
  protected FieldMetaData fieldMetaData;
  protected string localeMessage;
  
  public BusinessException() : base() {
    localeMessage = null;
  }
  public BusinessException(string message) : base(message) {
    localeMessage = null;
  }
  public BusinessException(FieldMetaData fieldMetaData, string message) : base(message) {
    this.fieldMetaData = fieldMetaData;
    localeMessage = null;
  }
  public BusinessException(FieldMetaData fieldMetaData) : base(fieldMetaData.Name) {
    this.fieldMetaData = fieldMetaData;
  }
  public FieldMetaData FieldMetaData {
    get { return fieldMetaData; }
  }
  public override string Message {
    get {
      if (localeMessage != null) return localeMessage;
      else return base.Message;
    }
  }
  public string LocaleMessage {
    get {
      return localeMessage;
    }
    set {
      localeMessage = value;
    }
  }
}

public class UserInputException : BusinessException {
  protected object val;
  public UserInputException() : base() { }
  public UserInputException(string message) : base(message) { }
  public UserInputException(FieldMetaData fieldMetaData, object val) : base(fieldMetaData) {
    this.val = val;
  }
  public override string Message {
    get {
      if (localeMessage != null) return localeMessage;
      else {
        string msg = (val != null) ? "Invalid value " + val + " (type = " + val.GetType() + ")" : "Null value";
        if (fieldMetaData != null) msg += " for field " + fieldMetaData.Name;
        return msg;
      }
    }
  }
}

public class FieldNotNullableException : UserInputException {
  public FieldNotNullableException() : base() { }
  public FieldNotNullableException(string message) : base(message) { }
  public FieldNotNullableException(FieldMetaData fieldMetaData) : base(fieldMetaData, null) {
  }
  public override string Message {
    get {
      if (localeMessage != null) return localeMessage;
      else return "Field " + fieldMetaData.Name + " is mandatory";
    }
  }
}


} // namespace
