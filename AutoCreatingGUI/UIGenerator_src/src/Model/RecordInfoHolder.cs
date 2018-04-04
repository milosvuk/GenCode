using System;
using Greco.View;

namespace Greco.Model {
  /// <summary>
  /// Description résumée de RecordInfoHolder.
  /// </summary>
public abstract class RecordInfoHolder {
  protected RecordInfo recordInfo;
  protected RecordRenderInfo renderInfo;

  internal RecordInfoHolder(RecordInfo recordInfo) {
    this.recordInfo = recordInfo;
    renderInfo = null;
  }

  public RecordInfo RecordInfo {
    get { return recordInfo; }
  }

  public RecordRenderInfo GetRenderInfo() {
    return GetRenderInfo(null);
  }

  public RecordRenderInfo GetRenderInfo(RenderContext renderContext) {
    if (renderInfo == null) renderInfo = recordInfo.GetRenderInfo(renderContext, false);
    return renderInfo;
  }

  public RecordRenderInfo GetCustomizedRenderInfo() {
    return GetCustomizedRenderInfo(null);
  }

  public RecordRenderInfo GetCustomizedRenderInfo(RenderContext renderContext) {
    if (renderInfo == null) {
      renderInfo = (RecordRenderInfo) recordInfo.GetRenderInfo(renderContext, true).Clone();
    }
    return renderInfo;
  }

}


} // namespace
