<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="invoiceSingleRecord.aspx.cs" Inherits="invoiceSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidRecInv" runat="server" Text="idRecInv"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidRecInv" runat="server"></asp:TextBox>
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
<asp:Label ID="lblDateOfInv" runat="server" Text="DateOfInv"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateOfInv" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidExpense" runat="server" Text="idExpense"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidExpense" runat="server"></asp:TextBox>
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
<asp:Label ID="lblTaxPerc" runat="server" Text="TaxPerc"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtTaxPerc" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblTaxAmount" runat="server" Text="TaxAmount"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtTaxAmount" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblTotalAmount" runat="server" Text="TotalAmount"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtTotalAmount" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblFinalized" runat="server" Text="Finalized"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtFinalized" runat="server"></asp:TextBox>
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
