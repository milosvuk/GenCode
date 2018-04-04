<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="capitalexpandSingleRecord.aspx.cs" Inherits="capitalexpandSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidCapitalExp" runat="server" Text="idCapitalExp"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidCapitalExp" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidProperty" runat="server" Text="idProperty"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidProperty" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIdExpense" runat="server" Text="IdExpense"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIdExpense" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateOfCap" runat="server" Text="DateOfCap"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateOfCap" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDetails" runat="server" Text="Details"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDetails" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAmount" runat="server" Text="Amount"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblActive" runat="server" Text="Active"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtActive" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidCompany" runat="server" Text="idCompany"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidCompany" runat="server"></asp:TextBox>
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
