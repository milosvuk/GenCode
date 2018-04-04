<%@ Page Language="C#" Inherits="Greco.View.Web.RenderContextPage" Trace="true" %>
<%@ Register TagPrefix="ucMenu" TagName="Menu" Src="Menu.ascx" %>
<%@ import Namespace="System.IO" %>
<%@ import Namespace="Greco.Util" %>
<script runat="server">

    void Page_Init(object sender, EventArgs e) {
      if (SessionConfig.CultureInfo == null) {
        // default locale = "en" (only for demo)
        SessionConfig.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("en");
      }
      base.Page_Init(sender, e);
      if (RenderContext.IsLogoutAction) {
        Session["IsLogged"] = null;
      }
    }
    
    void btOK_Click(object sender, EventArgs e) {
      if ((loginControl.Text == "admin") && (passwordControl.Text == "admin")) {
        Session["IsLogged"] = true;
        Session["IsAdmin"] = true;
      }
      else if ((loginControl.Text == "guest") && (passwordControl.Text == "guest")) {
        Session["IsLogged"] = true;
        Session["IsAdmin"] = false;
      }
      else {
        Session["IsLogged"] = null;
      }
    }

</script>
<!-- #include file="_Top.inc"-->
<h2><%=GetText("global.title")%></h2>
<%=GetText("home.welcome")%><br>
<%  if (Session["IsLogged"] == null) { %>
<hr>
<form title="Login" runat="server">
<table >
  <tr>
    <td>Login :</td>
    <td><asp:TextBox id="loginControl" runat="server" value="admin"></asp:TextBox></td>
  </tr>
  <tr>
    <td>Password :</td>
    <td><asp:TextBox id="passwordControl" runat="server" password="true" value="admin"></asp:TextBox></td>
  </tr>
</table>
<asp:Button id="btOK" runat="server" Text="OK" onclick="btOK_Click"></asp:Button><br>
<%=GetText("home.loginAsAdmin")%><br>
<%=GetText("home.loginAsGuest")%>
</form>
<hr>
<%  }

    if (RenderContext.IsFrench) { %>
<br>
<!-- #include file="Home_fr.inc"-->
<%  }
    else {
%>
<br>
<!-- #include file="Home_en.inc"-->
<%  } %>

<!-- #include file="_Bottom.inc"-->