<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="projectclassSingleRecord.aspx.cs" Inherits="projectclassSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidprojectclass" runat="server" Text="idprojectclass"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidprojectclass" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_project" runat="server" Text="id_project"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_project" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListproject" runat="server"></asp:DropDownList>
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
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
</td>
<td>
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"/>
</td>
</tr>
 </table>
<asp:Label ID="Label2" runat="server" Text="2userid" Visible="False"></asp:Label>
</asp:Content>
