<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="seniorcitizenSingleRecord.aspx.cs" Inherits="seniorcitizenSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidseniorcitizen" runat="server" Text="idseniorcitizen"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidseniorcitizen" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblIDcard" runat="server" Text="IDcard"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtIDcard" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAddress1" runat="server" Text="Address1"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAddress2" runat="server" Text="Address2"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblAddress3" runat="server" Text="Address3"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtAddress3" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblLocCoordLat" runat="server" Text="LocCoordLat"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtLocCoordLat" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblLocCoordLong" runat="server" Text="LocCoordLong"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtLocCoordLong" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblMobile" runat="server" Text="Mobile"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblComment" runat="server" Text="Comment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
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
