<%@ Application language="C#" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Collections" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.Common" %>
<%@ import Namespace="Greco.Util" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="log4net" %>
<%@ import Namespace="log4net.Config" %>

<script runat="server">

  public void Application_Start(Object sender, EventArgs e) {
    // Code that runs on application startup
    XmlConfigurator.Configure();
    Log.Info("Webapp started");
    ApplicationConfig.Init(Server.MapPath("."), "Modules\\Config.txt", TargetType.Web);
  }

  public void Application_End(Object sender, EventArgs e) {
    // Code that runs on application shutdown
  }

  public void Application_Error(Object sender, EventArgs e) {
    // Code that runs when an unhandled error occurs
  }

  public void Session_Start(Object sender, EventArgs e) {
    // Code that runs when a new session is started
  }

  public void Session_End(Object sender, EventArgs e) {
    // Code that runs when a session ends
  }

</script>
