<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="measurementSingleRecord.aspx.cs" Inherits="measurementSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidmeasurement" runat="server" Text="idmeasurement"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidmeasurement" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcodeoflocation" runat="server" Text="codeoflocation"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcodeoflocation" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbldateofmeasurement" runat="server" Text="dateofmeasurement"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdateofmeasurement" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblcodeofindicator" runat="server" Text="codeofindicator"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcodeofindicator" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblvalueofmeasurement" runat="server" Text="valueofmeasurement"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtvalueofmeasurement" runat="server"></asp:TextBox>
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
<asp:Label ID="lblweekm" runat="server" Text="weekm"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtweekm" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblmonthm" runat="server" Text="monthm"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtmonthm" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblyearm" runat="server" Text="yearm"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtyearm" runat="server"></asp:TextBox>
</td>
</tr>
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
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
</td>
<td>
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"/>
</td>
</tr>
 </table>
<asp:Label ID="Label2" runat="server" Text="2userid" Visible="False"></asp:Label>
</asp:Content>
