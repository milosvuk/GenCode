<%@ Page Language="C#" Inherits="Greco.View.Web.RecordTablePage" Debug="true" Trace="true" %>
<%@ Register TagPrefix="ucMenu" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="ucList" TagName="RecordList" Src="RecordList.ascx" %>
<%@ Register TagPrefix="ucRecord" TagName="Record" Src="Record.ascx" %>
<%@ Register TagPrefix="ucPagination" TagName="Pagination" Src="Pagination.ascx" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Collections" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="Greco.Model" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="Greco.View.Web" %>
<%@ import Namespace="Greco.Util" %>
<script runat="server">

    void Page_Init(object sender, EventArgs e) {
      base.Page_Init(sender, e);
      if (HasVisibleParameters) {
        paramRecordControl.Record = ParametersRecord;
        paramRecordControl.InitControl();
        paramRecordControl.BuildControls();
      }
      listControl.InitControl();
    }

    void Page_Load(object sender, EventArgs e) {
      base.Page_Load(sender, e);
      // on récupère les paramètres avant de lancer le reader
      if (HasVisibleParameters) {
        if (!IsPostBack) paramRecordControl.RecordToControls();
        else paramRecordControl.ControlsToRecord();
      }

      // on pourrait aussi faire ça seulement si on a cliqué sur Search
      ExecuteReader();

      if (IsReaderMode) {
        listControl.RecordReader = RecordReader;
        paginationControl.PageSize = 0;
      }
      else {
        listControl.RecordTable = RecordTable;
        paginationControl.PageSize = RecordRenderInfo.PageSize;
        paginationControl.PageNum = PageNum;
        paginationControl.RowCount = RecordTable.Count;
      }

      btAdd.Text = GetText("button.Add");
      btSearch.Text = GetText("button.Search");
    }

    void btSearch_Click(object sender, EventArgs e) {
      // pas grand chose à faire car tout est déjà dans le Load
      Trace.Warn("btSearch_Click : " + ParametersRecord + ", action = " + RenderContext.Action);
    }

    void btAdd_Click(object sender, EventArgs e) {
      Response.Redirect(DetailNewUrl);
    }

    public override void AddMessage(string message, MessageType messageType) {
      // TODO : utiliser validationSummary si c'est possible
      // Faire plusieurs messages à la suite
      lblMessage.Visible = true;
      lblMessage.Text = message;
      switch (messageType) {
        case MessageType.Info:
          lblMessage.ForeColor = System.Drawing.Color.Blue;
          break;
        case MessageType.Warning:
          lblMessage.ForeColor = System.Drawing.Color.Magenta;
          break;
        default:
          lblMessage.ForeColor = System.Drawing.Color.Red;
          break;
      }
    }

</script>
<!-- #include file="_Top.inc"-->
  <asp:Label id="lblMessage" runat="server" Visible="false"></asp:Label>
  <form runat="server">
<%  if (HasVisibleParameters) { %>
    <ucRecord:Record id="paramRecordControl" runat="server"></ucRecord:Record>
    <input type="hidden" name="__action" value="search">
    <asp:Button id="btSearch" runat="server" Text="Search" onclick="btSearch_Click"></asp:Button>
<%  } %>
    <ucList:RecordList id="listControl" runat="server"></ucList:RecordList>
    <ucPagination:Pagination id="paginationControl" runat="server"></ucPagination:Pagination>
<%  if (listControl.CanInsert) { %>
    <asp:Button id="btAdd" runat="server" Text="Add" onclick="btAdd_Click"></asp:Button>
<%  } %>
  </form>

<!-- #include file="_Bottom.inc"-->
