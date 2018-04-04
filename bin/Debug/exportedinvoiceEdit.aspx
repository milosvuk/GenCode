<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="exportedinvoiceEdit.aspx.cs" Inherits="exportedinvoiceEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
<table style="width: 100%;">
<tr>
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td>
    Class</td>
<td>
<asp:Button ID="btnSearch" runat="server" Text="New" Width="25%" 
        onclick="btnSearch_Click"/>
</td>
</tr>
<tr>
<td>
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td>
<asp:Label ID="lblView" runat="server" Text="View"></asp:Label>
</td>
<td>
 <asp:GridView ID="GridView1" runat="server"
AutoGenerateColumns="False" DataKeyNames="idexportedinvoice"
        onrowediting="GridView1_RowEditing" BackColor="#CCCCCC" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"
>
   <Columns>
<asp:CommandField HeaderText="" ShowHeader="False" ShowEditButton="True"/>
<asp:BoundField DataField="idexportedinvoice" HeaderText="idexportedinvoice" />
<asp:BoundField DataField="idinvoice" HeaderText="idinvoice" />
<asp:BoundField DataField="typeofac" HeaderText="typeofac" />
<asp:BoundField DataField="accountreference" HeaderText="accountreference" />
<asp:BoundField DataField="nominalacref" HeaderText="nominalacref" />
<asp:BoundField DataField="department" HeaderText="department" />
<asp:BoundField DataField="dateofinv" HeaderText="dateofinv" />
<asp:BoundField DataField="referencecode" HeaderText="referencecode" />
<asp:BoundField DataField="details" HeaderText="details" />
<asp:BoundField DataField="netamount" HeaderText="netamount" />
<asp:BoundField DataField="taxcode" HeaderText="taxcode" />
<asp:BoundField DataField="taxamount" HeaderText="taxamount" />
<asp:BoundField DataField="exchangerate" HeaderText="exchangerate" />
<asp:BoundField DataField="extrareference" HeaderText="extrareference" />
<asp:BoundField DataField="username" HeaderText="username" />
<asp:BoundField DataField="projectrefn" HeaderText="projectrefn" />
<asp:BoundField DataField="costocderefn" HeaderText="costocderefn" />
    </Columns>
     <FooterStyle BackColor="#CCCCCC" />
     <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
     <RowStyle BackColor="White" />
     <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
     <SortedAscendingCellStyle BackColor="#F1F1F1" />
     <SortedAscendingHeaderStyle BackColor="#808080" />
     <SortedDescendingCellStyle BackColor="#CAC9C9" />
     <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label2IDuser" Visible="False"></asp:Label>
</td>
<td>
    <br />
    <asp:Label ID="LabelIDrec" runat="server" Text="0" Visible="False"></asp:Label>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
    </td>
</tr>
 </table>
</asp:Content>
