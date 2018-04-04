<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="paymentSingleRecord.aspx.cs" Inherits="paymentSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidRecPayment" runat="server" Text="idRecPayment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidRecPayment" runat="server"></asp:TextBox>
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
<asp:Label ID="lblidCustomer" runat="server" Text="idCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateOfPayment" runat="server" Text="DateOfPayment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateOfPayment" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDescription1" runat="server" Text="Description1"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDescription1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDescription2" runat="server" Text="Description2"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDescription2" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAmountPaid" runat="server" Text="AmountPaid"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAmountPaid" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAmountAlocated" runat="server" Text="AmountAlocated"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAmountAlocated" runat="server"></asp:TextBox>
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
