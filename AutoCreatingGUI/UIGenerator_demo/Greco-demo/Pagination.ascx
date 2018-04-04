<%@ Control Language="C#" %>
<%@ import Namespace="Greco.Util" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="Greco.View.Web" %>
<script runat="server">

    int pageSize = 10, pageNum = 1, rowCount = 0;

    public int PageSize {
      get { return pageSize; }
      set { pageSize = value; }
    }

    public int PageNum {
      get { return pageNum; }
      set { pageNum = value; }
    }

    public int RowCount {
      get { return rowCount; }
      set { rowCount = value; }
    }

</script>
<%  if (pageSize > 0)  {
      if (rowCount <= pageSize) { %>
<br>
<%    }
      else {
        RenderContextPage renderContextPage = Page as RenderContextPage;
        string pageStr = (renderContextPage != null) ? renderContextPage.GetText("list.Page") : GlobalTexts.GetText("list.Page");
%>
<center><%=pageStr%>&nbsp;
<%      int nbPages = ((rowCount - 1) / pageSize) + 1;
        for (int i = 1; i <= nbPages; i++) {
          string tag1 = (i == pageNum)
                      ? "<b>"
                      : "<a href=\"" + UrlUtil.RewriteQueryString(Request.QueryString, ViewConstants.REQUEST_PAGE_NUM, "" + i) + "\">";
          string tag2 = (i == pageNum) ? "</b>" : "</a>";
%>
<%=tag1 + i + tag2%>&nbsp;
<%      }
      }
%>
</center>
<%
   }
%>
