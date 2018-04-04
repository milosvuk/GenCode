<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DocumentRecordsEdit.aspx.cs" Inherits="DocumentRecordsEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

<script src="DbScripts/docdocScripts.js" type="text/javascript">
    </script>

    <table style="width: 100%;">


<tr>
<td>
    Document</td>
<td>
<asp:Button ID="btnSearch" runat="server" Text="New" Width="175px" onclick="btnSearch_Click" 
          />
</td>
</tr>

 
<tr>
<td style="height: 5px">
    &nbsp;</td>
<td style="height: 5px">
    &nbsp;</td>
</tr>

<tr>
<td>
    Property</td>
<td>
    <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Text="All" />
    </td>
</tr>

<tr>

<td>
    &nbsp;</td>
<td>
    <asp:DropDownList ID="DropDownList1" Width="175px" runat="server">
    </asp:DropDownList>
    </td>
</tr>

<tr>
<td style="height: 5px">
    </td>
<td style="height: 5px">
    </td>
</tr>

<tr>
<td style="height: 33px">
    Description</td>
<td style="height: 33px">
    <asp:TextBox ID="txtDesc" runat="server" Visible="True" Width="175px" ></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Width="219px" 
        Text="Order by first letter" onclick="Button2_Click" />
    </td>
</tr>

<tr>
<td style="height: 5px">
    </td>
<td style="height: 5px">
    </td>
</tr>

<tr>
<td style="height: 33px">
    Keyword</td>
<td style="height: 33px">
    <asp:TextBox ID="txtBoxKeyword" runat="server" Width="175px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Width="219px" Text="Search" 
        onclick="Button1_Click" />
    </td>
</tr>






<tr>
<td style="height: 10px">
    &nbsp;</td>
<td style="height: 10px">
    &nbsp;</td>
</tr>




<tr>
<td>
<asp:Label ID="lblView" runat="server" Text="List"></asp:Label>
</td>
<td>
 <asp:GridView ID="GridView1" runat="server"
AutoGenerateColumns="False" DataKeyNames="idRecDocument" 
        onrowediting="GridView1_RowEditing" CellPadding="4" 
        ForeColor="#333333" onrowdeleting="GridView1_RowDeleting" GridLines="None"

>
     <AlternatingRowStyle BackColor="White" />
   <Columns>

 <asp:CommandField DeleteText="View" ShowDeleteButton="True" />
<asp:BoundField DataField="idRecDocument" HeaderText="idRecDocument" Visible="False"  />
<asp:BoundField DataField="idProperty" HeaderText="idProperty" Visible="False" />
<asp:BoundField DataField="DateOfDocFull" HeaderText="Date"   />
<asp:BoundField DataField="Description" HeaderText="Description" />
<asp:BoundField DataField="TypeOfDoc" HeaderText="Name" />
<asp:BoundField DataField="Keyword1" HeaderText="Keyword" />
<asp:BoundField DataField="Keyword2" HeaderText="Keyword" />
<asp:BoundField DataField="Keyword3" HeaderText="Keyword" />
<asp:CommandField HeaderText="" ShowHeader="False" ShowEditButton="True"/>

    </Columns>
     <EditRowStyle BackColor="#2461BF" />
     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
     <RowStyle BackColor="#EFF3FB" />
     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
     <SortedAscendingCellStyle BackColor="#F5F7FB" />
     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
     <SortedDescendingCellStyle BackColor="#E9EBEF" />
     <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
</td>
</tr>

<tr>
<td>
    &nbsp;</td>
<td>
    <asp:Label ID="lblFilterName" runat="server" Font-Bold="True" 
        Font-Size="Medium" Font-Underline="True" Text="Filter" Visible="False"></asp:Label>
    </td>
</tr>

<tr>
<td>
    &nbsp;</td>
<td>
    <asp:Label ID="lblFilter" runat="server" Font-Bold="True" Font-Size="Medium" 
        ForeColor="#FF3300" Text="All Documents" Visible="False"></asp:Label>
    </td>
</tr>

<tr>
<td>
<asp:Label ID="lblbtn" runat="server" Text=" "></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label2IDuser" Visible="False"></asp:Label>
</td>
<td>
    <asp:Label ID="lblTypeDoc" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="LabelIDrec" runat="server" Text="0" Visible="False"></asp:Label>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
    <br />
    <asp:ListBox ID="ListBox2" runat="server" Visible="False"></asp:ListBox>
    </td>
</tr>
 </table>


</asp:Content>

