<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="infoSingleRecord.aspx.cs" Inherits="infoSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidinfo" runat="server" Text="idinfo"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidinfo" runat="server"></asp:TextBox>
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
<asp:Label ID="lbldescription" runat="server" Text="description"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdescription" runat="server"></asp:TextBox>
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
<asp:Label ID="lblid_company" runat="server" Text="id_company"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_company" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListcompany" runat="server"></asp:DropDownList>
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
