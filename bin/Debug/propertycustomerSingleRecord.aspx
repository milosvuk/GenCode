<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="propertycustomerSingleRecord.aspx.cs" Inherits="propertycustomerSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
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
<asp:Label ID="lblLeaseAgDateFrom" runat="server" Text="LeaseAgDateFrom"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtLeaseAgDateFrom" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblLeaseAgDateTo" runat="server" Text="LeaseAgDateTo"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtLeaseAgDateTo" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidNotary" runat="server" Text="idNotary"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidNotary" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateOfAg" runat="server" Text="DateOfAg"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateOfAg" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblFrenqOfPayment" runat="server" Text="FrenqOfPayment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtFrenqOfPayment" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAmountOfContract" runat="server" Text="AmountOfContract"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAmountOfContract" runat="server"></asp:TextBox>
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
<asp:Label ID="lblIncreaseCostOfLiving" runat="server" Text="IncreaseCostOfLiving"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIncreaseCostOfLiving" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblFreqInDaysToApplyIncrease" runat="server" Text="FreqInDaysToApplyIncrease"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtFreqInDaysToApplyIncrease" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblDateofLastinvoice" runat="server" Text="DateofLastinvoice"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtDateofLastinvoice" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAmtOfLastInvoice" runat="server" Text="AmtOfLastInvoice"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAmtOfLastInvoice" runat="server"></asp:TextBox>
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
