<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="propertycustomerincreaseSingleRecord.aspx.cs" Inherits="propertycustomerincreaseSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidPropertyCustomerincrease" runat="server" Text="idPropertyCustomerincrease"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidPropertyCustomerincrease" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidPropertyCustomer" runat="server" Text="idPropertyCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidPropertyCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateFrom" runat="server" Text="DateFrom"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateFrom" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateTo" runat="server" Text="DateTo"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateTo" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIncreasePerc" runat="server" Text="IncreasePerc"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIncreasePerc" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIncreaseAmount" runat="server" Text="IncreaseAmount"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIncreaseAmount" runat="server"></asp:TextBox>
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
