// FieldMetaDataCollection.cs
//
using System;
using System.Collections;

namespace Greco.Model {

/// <summary>
/// Summary description for FieldMetaDataCollection.
/// </summary>
public class FieldMetaDataCollection : CollectionBase {
  private RecordMetaData recordMetaData;
  private Hashtable nameIndexes;

  /// <summary>
  /// Creates a new instance of FieldMetaDataCollection
  /// </summary>
  public FieldMetaDataCollection(RecordMetaData recordMetaData) {
    this.recordMetaData = recordMetaData;
    nameIndexes = new Hashtable();
  }

  public int GetFieldIndex(string fieldName) {
    object obj = nameIndexes[recordMetaData.lowerNames ? fieldName.ToLower() : fieldName];
    if (obj == null) throw new FieldNotFoundException(recordMetaData, fieldName);
    return (int) obj;
  }

  public bool Contains(string fieldName) {
    return nameIndexes.ContainsKey(recordMetaData.lowerNames ? fieldName.ToLower() : fieldName);
  }

  private void refreshNameIndexes() {
    foreach (FieldMetaData fmd in List) {
      nameIndexes[fmd.Name] = List.IndexOf(fmd);
    }
  }

  public FieldMetaData this[string fieldName] {
    get { return this[GetFieldIndex(fieldName)]; }
    set { List[GetFieldIndex(fieldName)] = value; }
  }

  public FieldMetaData this[int index] {
    get { return (FieldMetaData) List[index]; }
    set { List[index] = value; }
  }

  public int Add(FieldMetaData value) {
    int index= List.Add(value);
    nameIndexes[recordMetaData.lowerNames ? value.Name.ToLower() : value.Name] = index;
    return index;
  }

  public int IndexOf(FieldMetaData value) {
    return List.IndexOf(value);
  }

  public void Insert(int index, FieldMetaData value) {
    List.Insert(index, value);
    refreshNameIndexes();
  }

  public void Remove(FieldMetaData value) {
    List.Remove(value);
    refreshNameIndexes();
  }

  public bool Contains(FieldMetaData value) {
    // If value is not of type FieldMetaData, this will return false.
    return List.Contains(value);
  }

  protected override void OnInsert(int index, Object value) {
    if (value.GetType() != Type.GetType("Greco.Model.FieldMetaData") )
      throw new ArgumentException("value must be of type FieldMetaData.", "value");
  }

  protected override void OnRemove(int index, Object value)  {
    if (value.GetType() != Type.GetType("Greco.Model.FieldMetaData"))
      throw new ArgumentException( "value must be of type FieldMetaData.", "value");
  }

  protected override void OnSet( int index, Object oldValue, Object newValue )  {
    if (newValue.GetType() != Type.GetType("Greco.Model.FieldMetaData"))
      throw new ArgumentException( "newValue must be of type FieldMetaData.", "newValue");
  }

  protected override void OnValidate( Object value )  {
    if (value.GetType() != Type.GetType("Greco.Model.FieldMetaData"))
      throw new ArgumentException( "value must be of type FieldMetaData.");
  }
}


} // namespace

