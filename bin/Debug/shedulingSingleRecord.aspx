<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="shedulingSingleRecord.aspx.cs" Inherits="shedulingSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidsheduling" runat="server" Text="idsheduling"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidsheduling" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_professional" runat="server" Text="id_professional"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_professional" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListprofessional" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_seniorcitizen" runat="server" Text="id_seniorcitizen"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_seniorcitizen" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListseniorcitizen" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_services" runat="server" Text="id_services"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_services" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListservices" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbldateofvisit" runat="server" Text="dateofvisit"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtdateofvisit" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbltimeovisit" runat="server" Text="timeovisit"></asp:Label>
</td>
<td>
<asp:TextBox ID="txttimeovisit" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbltimeovisitdec" runat="server" Text="timeovisitdec"></asp:Label>
</td>
<td>
<asp:TextBox ID="txttimeovisitdec" runat="server"></asp:TextBox>
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
