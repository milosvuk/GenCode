<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="propertycustomerEdit.aspx.cs" Inherits="propertycustomerEdit" %>
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
AutoGenerateColumns="False" DataKeyNames="idPropertyCustomer"
        onrowediting="GridView1_RowEditing" BackColor="#CCCCCC" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"
>
   <Columns>
<asp:CommandField HeaderText="" ShowHeader="False" ShowEditButton="True"/>
<asp:BoundField DataField="idPropertyCustomer" HeaderText="idPropertyCustomer" />
<asp:BoundField DataField="idProperty" HeaderText="idProperty" />
<asp:BoundField DataField="idCustomer" HeaderText="idCustomer" />
<asp:BoundField DataField="LeaseAgDateFrom" HeaderText="LeaseAgDateFrom" />
<asp:BoundField DataField="LeaseAgDateTo" HeaderText="LeaseAgDateTo" />
<asp:BoundField DataField="idNotary" HeaderText="idNotary" />
<asp:BoundField DataField="DateOfAg" HeaderText="DateOfAg" />
<asp:BoundField DataField="FrenqOfPayment" HeaderText="FrenqOfPayment" />
<asp:BoundField DataField="AmountOfContract" HeaderText="AmountOfContract" />
<asp:BoundField DataField="IncreasePerc" HeaderText="IncreasePerc" />
<asp:BoundField DataField="IncreaseAmount" HeaderText="IncreaseAmount" />
<asp:BoundField DataField="IncreaseCostOfLiving" HeaderText="IncreaseCostOfLiving" />
<asp:BoundField DataField="FreqInDaysToApplyIncrease" HeaderText="FreqInDaysToApplyIncrease" />
<asp:BoundField DataField="DateofLastinvoice" HeaderText="DateofLastinvoice" />
<asp:BoundField DataField="AmtOfLastInvoice" HeaderText="AmtOfLastInvoice" />
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
