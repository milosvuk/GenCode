<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="linkmonitorprojectSingleRecord.aspx.cs" Inherits="linkmonitorprojectSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidlinkmonitorproject" runat="server" Text="idlinkmonitorproject"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidlinkmonitorproject" runat="server"></asp:TextBox>
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
<asp:Label ID="lblid_monitorpoints" runat="server" Text="id_monitorpoints"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_monitorpoints" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListmonitorpoints" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidcompamy" runat="server" Text="idcompamy"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidcompamy" runat="server"></asp:TextBox>
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
