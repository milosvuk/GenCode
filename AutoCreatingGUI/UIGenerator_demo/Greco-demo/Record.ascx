<%@ Control Language="C#" Inherits="Greco.View.Web.RecordControl" Debug="true" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Collections" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="Greco.Model" %>
<%@ import Namespace="Greco.View" %>
<%@ import Namespace="Greco.View.Web" %>
<%@ import Namespace="Greco.Util" %>
<script runat="server">

    // ne peut être dans l'Init du UserControl car il serait appelé avant l'Init de la page
    // doit donc être appelé explicitement lors de l'Init de la page parente
    public void BuildControls() {
      if (Record == null) {
        Controls.Add(new LiteralControl("<h2>No record found in RecordControl</h2>\n"));
        return;
      }
    
      Controls.Add(new LiteralControl("<h2>" + HttpUtility.HtmlEncode(EditTitle) + "</h2>\n"));
    
      HtmlInputHidden hidAction = new HtmlInputHidden();
      hidAction.ID = ViewConstants.REQUEST_ACTION;
      hidAction.Value = (Record.State == DataRowState.Added) ? ViewConstants.ACTION_INSERT
                                                              : ViewConstants.ACTION_UPDATE;
      Controls.Add(hidAction);
    
      BuildControlTree(this, RecordRenderInfo.RootControlNode);
    }
    
    public override void AddEditLabel(Control parent, FieldRenderInfo fri) {
      parent.Controls.Add(new LiteralControl(fri.EditLabel));
    
      string sep;
      if (CanWrite && !IsEditNullable(fri.Name)) sep = "* : ";
      else sep = " : ";
    
      parent.Controls.Add(new LiteralControl(sep));
    }
    
    public override Control AddEditControl(Control parent, FieldRenderInfo fri) {
      string fieldName = fri.Name;
      Control editControl = CreateEditControl(fieldName);
      parent.Controls.Add(editControl);
    
      if (CanWrite) {
        if (!IsEditNullable(fieldName)
          && ((editControl as TextBox != null) || (editControl as ListBox != null)
          || (editControl as HtmlInputText != null) || (editControl as HtmlInputFile != null)
          || (editControl as HtmlSelect != null) || (editControl as HtmlTextArea != null)
          )) {
          RequiredFieldValidator rfv = new RequiredFieldValidator();
          rfv.ID = "rfv" + fieldName;
          rfv.ControlToValidate = RecordRenderInfo.GetEditControlID(fieldName);
          string messageFormat = GetText("error.FieldNotNullable");
          rfv.ErrorMessage = string.Format(CultureInfo, messageFormat, fri.EditLabel);
          rfv.Text = "*";
          parent.Controls.Add(rfv);
        }
      }
      return editControl;
    }
    
    // la suite dans RecordControl.cs !

</script>
