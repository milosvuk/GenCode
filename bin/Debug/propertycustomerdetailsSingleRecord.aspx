<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="propertycustomerdetailsSingleRecord.aspx.cs" Inherits="propertycustomerdetailsSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidpropertcustomerdetails" runat="server" Text="idpropertcustomerdetails"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidpropertcustomerdetails" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_propertycustomer" runat="server" Text="id_propertycustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_propertycustomer" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListpropertycustomer" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbldatefrom" runat="server" Text="datefrom"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdatefrom" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbldateto" runat="server" Text="dateto"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdateto" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblnumberofdaystocreateinvoice" runat="server" Text="numberofdaystocreateinvoice"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtnumberofdaystocreateinvoice" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblamountforthatperiod" runat="server" Text="amountforthatperiod"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtamountforthatperiod" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblamountpereachinvoice" runat="server" Text="amountpereachinvoice"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtamountpereachinvoice" runat="server"></asp:TextBox>
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
<asp:Label ID="lblnumberofinvoicestogenerate" runat="server" Text="numberofinvoicestogenerate"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtnumberofinvoicestogenerate" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblgeneratedinvoicesfromthis" runat="server" Text="generatedinvoicesfromthis"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtgeneratedinvoicesfromthis" runat="server"></asp:TextBox>
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
