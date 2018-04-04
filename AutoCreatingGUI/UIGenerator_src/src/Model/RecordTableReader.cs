using System;
using System.Data;

namespace Greco.Model {
/// <summary>
/// Description résumée de RecordReader.
/// </summary>
public class RecordTableReader : IRecordReader {
  protected RecordTable rt;
  protected int currentRow, startRow, endRow;
  protected RecordInfo recordInfo;

  public RecordTableReader(RecordTable rt) : this(rt, 0, Int32.MaxValue) {
  }

  public RecordTableReader(RecordTable rt, int startRow, int endRow) {
    this.rt = rt;
    this.startRow = startRow;
    this.endRow = endRow;
    recordInfo = rt.RecordInfo;
    currentRow = 0;
  } 

  public Record CurrentRecord {
    get {
      Record rec = rt[currentRow - 1];
      return rec;
    }
  }

  public RecordInfo RecordInfo {
    get { return recordInfo; }
  }

  public int Depth {
    get { return 1; }
  }

  public bool IsClosed {
    get { return true; }
  }

  public int RecordsAffected  {
    get { return 0; }
  }

  public void Close() {
  }

  public DataTable GetSchemaTable() {
    return recordInfo.CreateDataTable();
  }

  public bool NextResult() {
    return Read();
  }

  public bool Read() {
    if (currentRow < startRow) currentRow = startRow;
    bool b = (currentRow < rt.Count) && (currentRow < endRow);
    if (b) currentRow++;
    return b;
  }

  public int RowNum {
    get { return currentRow; }
  }

  public object Parameters {
    get { return rt.Parameters; }
  }

  // Pour IEnumerator
  public object Current {
    get { return CurrentRecord; }
  }

  public bool MoveNext() {
    return Read();
  }
  
  public void Reset() {
    throw new ApplicationException("Not yet supported");
  }
}

} // namespace
