<%@ Control Language="C#" Inherits="Greco.View.Web.RecordTableControl" %>
<%@ import Namespace="System" %>
<%@ import Namespace="Greco.Model" %>
<%@ import Namespace="Greco.View" %>
<script runat="server">

    // TODO : rajouter autres propriétés tables (cellspacing, width, border, css)

</script>
<%  string titleLevel1 = ((Page as IRecordPage) != null) ? "<h3>" : "<h2>";
    string titleLevel2 = ((Page as IRecordPage) != null) ? "</h3>" : "</h2>";
%>
<%=titleLevel1 + HttpUtility.HtmlEncode(RecordRenderInfo.ListTitle) + titleLevel2%>
<table cellspacing="0" width="100%" border="1">
  <tbody>
    <tr>
<%  foreach (string columnName in RecordRenderInfo.ColumnOrderArray) {
      FieldRenderInfo fri = RecordRenderInfo.Fields[columnName];
      if (fri.ColumnVisible) {
%>
      <th><%=HttpUtility.HtmlEncode(fri.Label)%></th>
<%    }
    }
    if (CanDelete) {
%>
      <th>&nbsp;</th>
<%  } %>
    </tr>
<%  IRecordEnumerator recordEnumerator = GetRecordEnumerator();
    while (recordEnumerator.MoveNext()) {
      Record rec = recordEnumerator.CurrentRecord;
%>
    <tr>
<%    string s, link1 = null, link2 = null;
      foreach (string columnName in RecordRenderInfo.ColumnOrderArray) {
        FieldRenderInfo fri = RecordRenderInfo.Fields[columnName];
        if (fri.ColumnVisible) {
          if (fri.Link != null) {
            link1 = "<a href=\"" + MakeUrl(fri.Link, rec) + "\">";
            link2 = "</a>";
          }
          else {
            link1 = null;
            link2 = null;
          }
          if (fri.FieldMetaData.HasRelation && fri.RelationShowInTable) {
            RelationInfo relInfo = fri.FieldMetaData.RelationInfo;
            s = relInfo.GetDisplayLabel(DbConnection2, rec, RecordRenderInfo);
          }
          else {
            s = rec.GetString(columnName, RenderContext.CultureInfo);
          }
          if ((fri.Link != null) && (s == null)) {
            s = GetText("list.Null");
          }
          s = (s == null) ? "&nbsp;" : HttpUtility.HtmlEncode(s);
%>
      <td><%=link1%><%=s%><%=link2%></td>
<%      }
      }
      if (CanDelete) {
        link1 = "<a href=\"" + MakeDeleteUrl(rec) + "\" onclick=\"return confirm('" + GetText("list.ConfirmDelete") + "');\">";
        link2 = "</a>";
%>
      <td><%=link1%><%=GetText("list.Delete")%><%=link2%></td>
<%    } %>
    </tr>
<%  }
%>
  </tbody>
</table>
