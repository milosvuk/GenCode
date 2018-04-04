<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="paymentEditAll.aspx.cs" Inherits="paymentEditAll" %>
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
AutoGenerateColumns="False" DataKeyNames="idRecPayment"
        onrowediting="GridView1_RowEditing" BackColor="#CCCCCC" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"
>
   <Columns>
<asp:CommandField HeaderText="" ShowHeader="False" ShowEditButton="True"/>
<asp:BoundField DataField="idRecPayment" HeaderText="idRecPayment" />
<asp:BoundField DataField="idProperty" HeaderText="idProperty" />
<asp:BoundField DataField="idCustomer" HeaderText="idCustomer" />
<asp:BoundField DataField="DateOfPayment" HeaderText="DateOfPayment" />
<asp:BoundField DataField="Description1" HeaderText="Description1" />
<asp:BoundField DataField="Description2" HeaderText="Description2" />
<asp:BoundField DataField="AmountPaid" HeaderText="AmountPaid" />
<asp:BoundField DataField="AmountAlocated" HeaderText="AmountAlocated" />
<asp:BoundField DataField="Active" HeaderText="Active" />
<asp:BoundField DataField="idCompany" HeaderText="idCompany" />
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
