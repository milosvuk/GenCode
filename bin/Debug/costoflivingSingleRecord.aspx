<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="costoflivingSingleRecord.aspx.cs" Inherits="costoflivingSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidRecCostOfLiving" runat="server" Text="idRecCostOfLiving"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidRecCostOfLiving" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIncreaseInPerc" runat="server" Text="IncreaseInPerc"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIncreaseInPerc" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblStartDate" runat="server" Text="StartDate"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
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
