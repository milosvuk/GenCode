<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="invoice_full_details_not_paidEdit.aspx.cs" Inherits="invoice_full_details_not_paidEdit" %>
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
AutoGenerateColumns="False" DataKeyNames="idRecInv"
        onrowediting="GridView1_RowEditing" BackColor="#CCCCCC" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"
>
   <Columns>
<asp:CommandField HeaderText="" ShowHeader="False" ShowEditButton="True"/>
<asp:BoundField DataField="idRecInv" HeaderText="idRecInv" />
<asp:BoundField DataField="idProperty" HeaderText="idProperty" />
<asp:BoundField DataField="idCustomer" HeaderText="idCustomer" />
<asp:BoundField DataField="DateOfInv" HeaderText="DateOfInv" />
<asp:BoundField DataField="idExpense" HeaderText="idExpense" />
<asp:BoundField DataField="Amount" HeaderText="Amount" />
<asp:BoundField DataField="TaxPerc" HeaderText="TaxPerc" />
<asp:BoundField DataField="TaxAmount" HeaderText="TaxAmount" />
<asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" />
<asp:BoundField DataField="AmountPaid" HeaderText="AmountPaid" />
<asp:BoundField DataField="Finalized" HeaderText="Finalized" />
<asp:BoundField DataField="Description" HeaderText="Description" />
<asp:BoundField DataField="Active" HeaderText="Active" />
<asp:BoundField DataField="idCompany" HeaderText="idCompany" />
<asp:BoundField DataField="CustomerFullName" HeaderText="CustomerFullName" />
<asp:BoundField DataField="CodeOfProperty" HeaderText="CodeOfProperty" />
<asp:BoundField DataField="propertyname" HeaderText="propertyname" />
<asp:BoundField DataField="expenseDesc" HeaderText="expenseDesc" />
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
