<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="objclassesfieldsSingleRecord.aspx.cs" Inherits="objclassesfieldsSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidobjclassesfields" runat="server" Text="idobjclassesfields"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidobjclassesfields" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbltype" runat="server" Text="type"></asp:Label>
</td>
<td>
<asp:TextBox ID="txttype" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_objclasses" runat="server" Text="id_objclasses"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_objclasses" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListobjclasses" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidcompany" runat="server" Text="idcompany"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidcompany" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblactive" runat="server" Text="active"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtactive" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
</td>
<td>
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"/>
</td>
</tr>
 </table>
<asp:Label ID="Label2" runat="server" Text="2userid" Visible="False"></asp:Label>
</asp:Content>
