<%@ Control Language="C#" Inherits="Greco.View.Web.RenderContextControl" Debug="true" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Collections" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.Common" %>
<%@ import Namespace="System.Globalization" %>
<%@ import Namespace="Greco.Model" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="Greco.View.Web" %>
<%@ import Namespace="Greco.Util" %>
<script runat="server">

    RecordTable rt = RecordFactory.CreateRecordTable(null, "Menu.txt");

</script>
<%  IRecordInfoPage recordInfoPage = Page as IRecordInfoPage;
    string module  = (recordInfoPage != null) ? recordInfoPage.Module : null;
    string module2 = (recordInfoPage != null) && (recordInfoPage.ParentRecord != null)
                   ? recordInfoPage.ParentRecord.RecordInfo.Module : null;
    CultureInfo cultureInfo = RenderContext.CultureInfo;
    bool isEnglish = (cultureInfo != null)
                   ?  cultureInfo.Name.ToLower().StartsWith("en")
                   : false;
%>
<a href="./"><%=isEnglish ? "Home" : "Accueil"%></a><br>
<%  if (Session["IsLogged"] != null) {
      string displayCol = isEnglish ? "mnu_name_en" : "mnu_name";
      for (int i = 0; i < rt.Count; i++) {
        string s = rt.GetStringAt(i, "mnu_module");
        bool bold = s.Equals(module) || s.Equals(module2);
%>
<a href="List.aspx?__module=<%=s%>"><%=bold ? "<b>" : ""%><%=rt[i, displayCol]%><%=bold ? "</b>" : ""%></a><br>
<%    } %>
<br>
<a href="./?__action=logout">Logout</a><br>
<%  } %>
<br>
<br>
<%  string urlFR = UrlUtil.RewriteQueryString(Page.Request.QueryString,
                                              ViewConstants.REQUEST_LANG, "fr");
    string urlEN = UrlUtil.RewriteQueryString(Page.Request.QueryString,
                                              ViewConstants.REQUEST_LANG, "en");
%>
<%=GetText("menu.lang")%><br>
<a href="<%=urlFR%>">fr</a> / <a href="<%=urlEN%>">en</a><br><br>
<br>
<%  if (module != null) { %>
<%=GetText("menu.description")%><br>
<a href="modules/<%=module%>.txt" target="_blank">module</a><br>
<a href="resources/default/<%=module%>.txt" target="_blank">resource (default)</a><br>
<a href="resources/en/<%=module%>.txt" target="_blank">resource (en)</a><br>
<%  } %>
<br>
<br>
