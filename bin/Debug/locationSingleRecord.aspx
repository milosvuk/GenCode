<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="locationSingleRecord.aspx.cs" Inherits="locationSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidlocation" runat="server" Text="idlocation"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidlocation" runat="server"></asp:TextBox>
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
<asp:Label ID="lblnameoflocation" runat="server" Text="nameoflocation"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtnameoflocation" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbllatit" runat="server" Text="latit"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtlatit" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbllongi" runat="server" Text="longi"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtlongi" runat="server"></asp:TextBox>
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
<asp:Label ID="lblidcompany" runat="server" Text="idcompany"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidcompany" runat="server"></asp:TextBox>
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
