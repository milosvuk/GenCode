<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="customerSingleRecord.aspx.cs" Inherits="customerSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidcustomer" runat="server" Text="idcustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidcustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcustomerid" runat="server" Text="customerid"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcustomerid" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcustomersid" runat="server" Text="customersid"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcustomersid" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblnameOfCustomer" runat="server" Text="nameOfCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtnameOfCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblsurnameOfCustomer" runat="server" Text="surnameOfCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtsurnameOfCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbladdressOfCustomer" runat="server" Text="addressOfCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtaddressOfCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcityofCustomer" runat="server" Text="cityofCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcityofCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcountryOfCustomer" runat="server" Text="countryOfCustomer"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcountryOfCustomer" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_company" runat="server" Text="id_company"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_company" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListcompany" runat="server"></asp:DropDownList>
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
