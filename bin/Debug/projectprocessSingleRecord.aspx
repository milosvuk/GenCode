<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="projectprocessSingleRecord.aspx.cs" Inherits="projectprocessSingleRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
<asp:Label ID="lblidprojectprocess" runat="server" Text="idprojectprocess"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtidprojectprocess" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_project" runat="server" Text="id_project"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_project" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListproject" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblid_process" runat="server" Text="id_process"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtid_process" runat="server"></asp:TextBox>
<asp:DropDownList ID="DropDownListprocess" runat="server"></asp:DropDownList>
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
