<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DocumentSingleRecord.aspx.cs" Inherits="DocumentSingleRecord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

<table style="width: 100%;">

<tr>
<td>
<asp:Label ID="Label1" runat="server" Text="Document"></asp:Label>
</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td>
    &nbsp;</td>
<td>
<asp:TextBox ID="txtidRecDocument" runat="server" Visible="False"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidProperty" runat="server" Text="Property"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" Width="180px" runat="server">
    </asp:DropDownList>
<asp:TextBox ID="txtidProperty" runat="server" Visible="False"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdateofDoc" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
    &nbsp;</td>
<td>
    <asp:Calendar ID="Calendar1" runat="server" 
        onselectionchanged="Calendar1_SelectionChanged" 
        SelectedDate="06/03/2016 10:17:28"></asp:Calendar>
</td>
</tr>

<tr>
<td>
<asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblTypeOfDoc" runat="server" Text="Name" Visible="False"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtTypeOfDoc" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDocInBinFormat" runat="server" Text="Upload"></asp:Label>
</td>
<td>
    <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:TextBox ID="txtDocInBinFormat" runat="server" Visible="False"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblKeyword1" runat="server" Text="Keyword1"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtKeyword1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblKeyword2" runat="server" Text="Keyword2"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtKeyword2" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblKeyword3" runat="server" Text="Keyword3"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtKeyword3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIdCompany" runat="server" Text="IdCompany" Visible="False"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIdCompany" runat="server" Visible="False">1</asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
</td>
<td>
<asp:Button ID="btnSave" runat="server" Width="180px" Text="Save" onclick="btnSave_Click"/>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label2IDuser" Visible="False"></asp:Label>
</td>
</tr>
 </table>


</asp:Content>

