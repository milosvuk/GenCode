<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="indicatorSingleRecord.aspx.cs" Inherits="indicatorSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidindicator" runat="server" Text="idindicator"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidindicator" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcode" runat="server" Text="code"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcode" runat="server"></asp:TextBox>
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
<asp:Label ID="lbllowvaluerange" runat="server" Text="lowvaluerange"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtlowvaluerange" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblhighvaluerange" runat="server" Text="highvaluerange"></asp:Label>
</td>
<td>
<asp:TextBox ID="txthighvaluerange" runat="server"></asp:TextBox>
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
