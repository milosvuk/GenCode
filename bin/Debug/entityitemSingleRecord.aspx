<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="entityitemSingleRecord.aspx.cs" Inherits="entityitemSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidofentity" runat="server" Text="idofentity"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidofentity" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcodeofentity" runat="server" Text="codeofentity"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcodeofentity" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblnameofentity" runat="server" Text="nameofentity"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtnameofentity" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbludf1" runat="server" Text="udf1"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtudf1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbludf2" runat="server" Text="udf2"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtudf2" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbludf3" runat="server" Text="udf3"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtudf3" runat="server"></asp:TextBox>
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
