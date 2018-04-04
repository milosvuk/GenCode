<%@ Page Language="C#" Inherits="Greco.View.Web.RecordPage" Debug="true" Trace="true" %>
<%@ Register TagPrefix="ucMenu" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="ucRecord" TagName="Record" Src="Record.ascx" %>
<%@ Register TagPrefix="ucList" TagName="RecordList" Src="RecordList.ascx" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Collections" %>
<%@ import Namespace="System.Web.UI" %>
<%@ import Namespace="System.Web.UI.WebControls" %>
<%@ import Namespace="Greco.Db" %>
<%@ import Namespace="Greco.Model" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="Greco.View.Web" %>
<%@ import Namespace="Greco.Util" %>
<script runat="server">

    void Page_Init(object sender, EventArgs e) {
      base.Page_Init(sender, e);
      recordControl.Record = Record;
      recordControl.InitControl();
      recordControl.BuildControls();
      btCancel.Text = GetText("button.Cancel");
      btValidate.Text = GetText("button.Validate");
      btReturn.Text = GetText("button.Return");
      btEdit.Text = GetText("button.Edit");
    }

    void Page_Load(object sender, EventArgs e) {
      // on charge en premier le record avant l'appel à base.Page_Load car on doit
      // utiliser la connection pour les listbox avant l'ouverture du curseur sous-liste
      if (!IsPostBack) recordControl.RecordToControls();
      base.Page_Load(sender, e);
      if (!RenderContext.IsNewAction && RecordRenderInfo.HasDetailList) {
        subListControl.RecordReader = SubRecordReader;
        subListControl.ParentRecord = Record;
        subListControl.InitControl();
      }
    }

    void btCancel_Click(object sender, EventArgs e) {
      Response.Redirect(ReturnUrl);
    }

    void btOK_Click(object sender, EventArgs e) {
      // TODO : sur IE6 le formulaire n'est pas posté sur le serveur en cas d'erreur (Javascript)
      // sur Firefox, on passe ici même s'il y a une erreur et ça fait un double message d'erreur
      // comment savoir si le formulaire a bien passé les Validators ?
      try {
        recordControl.ControlsToRecord();
        BeginTransaction();
        SaveRecord();
        Commit();
        Response.Redirect(ReturnUrl);
      }
      catch (Exception exc) {
        AddMessage(exc.Message, MessageType.Error);
        if ((exc as BusinessException) == null) Log.Error(exc.Message, exc);
        Rollback();
        return;
      }
    }

    // passage en édition de notre record (si on était en mode view)
    void btEdit_Click(object sender, EventArgs e) {
      Response.Redirect(DetailEditUrl);
    }

    void btAddSublist_Click(object sender, EventArgs e) {
      Response.Redirect(subListControl.DetailNewUrl);
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

  <form runat="server" Id="form1">
    <asp:Label id="lblMessage" runat="server" Visible="false"></asp:Label>
    <ucRecord:Record id="recordControl" runat="server" RecordName="record"></ucRecord:Record>
<% if (RenderContext.IsViewAction || RenderContext.IsViewSummaryAction || !recordControl.CanWrite) { %>
    <asp:Button id="btReturn" causesValidation="false" runat="server" Text="Retour" onclick="btCancel_Click"></asp:Button>
<%   if (recordControl.CanWrite) { %>
    <asp:Button id="btEdit" runat="server" Text="Modifier" onclick="btEdit_Click"></asp:Button>
<%   }
   }
   else { %>
    <asp:Button id="btCancel" causesValidation="false" runat="server" Text="Annuler" onclick="btCancel_Click"></asp:Button>
    <asp:Button id="btValidate" runat="server" Text="Valider" onclick="btOK_Click"></asp:Button>
<% } %>
    <asp:ValidationSummary id="validationSummary" runat="server"></asp:ValidationSummary>
    <br>
<% if (!RenderContext.IsNewAction && RecordRenderInfo.HasDetailList) {
     btAdd.Text = GetText("button.AddSublist");
%>
    <ucList:RecordList id="subListControl" runat="server"></ucList:RecordList>
    <br>
<%   if (subListControl.CanInsert) { %>
    <asp:Button id="btAdd" runat="server" Text="Add" onclick="btAddSublist_Click"></asp:Button>
<%   }
   }
%>
  </form>

<!-- #include file="_Bottom.inc"-->
