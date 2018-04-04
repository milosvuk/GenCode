<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="alocateSingleRecord.aspx.cs" Inherits="alocateSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidRecAlocate" runat="server" Text="idRecAlocate"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidRecAlocate" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidInvoice" runat="server" Text="idInvoice"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidInvoice" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblidPayment" runat="server" Text="idPayment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidPayment" runat="server"></asp:TextBox>
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
