<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="healthcareprofessionalsSingleRecord.aspx.cs" Inherits="healthcareprofessionalsSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidprofessional" runat="server" Text="idprofessional"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidprofessional" runat="server"></asp:TextBox>
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
<asp:Label ID="lblsurname" runat="server" Text="surname"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtsurname" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblmobile" runat="server" Text="mobile"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblemail" runat="server" Text="email"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblusername" runat="server" Text="username"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblpassword" runat="server" Text="password"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
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
