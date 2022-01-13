<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/CRMMasteer.Master" AutoEventWireup="true" CodeBehind="Source.aspx.cs" Inherits="CRMModule.Sources" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Source Details</h2>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="10" ForeColor="#333333" GridLines="None" PageSize="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            
            <asp:BoundField DataField="SourceId" HeaderText="SourceID" SortExpression="SourceId" />
            
            <asp:BoundField DataField="SourceNmae" HeaderText="Source Name" SortExpression="SourceNmae" />
            <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" SortExpression="CreatedDate" />
            <asp:BoundField DataField="CreatedBy" HeaderText="Created By" SortExpression="CreatedBy" />
            <asp:BoundField DataField="ModifiedDate" HeaderText="Modified Date" SortExpression="ModifiedDate" />
            <asp:BoundField DataField="ModifiedBy" HeaderText="Modified By" SortExpression="ModifiedBy" />
            <asp:CommandField HeaderText="" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
        <EmptyDataTemplate>
				No Sources
			</EmptyDataTemplate>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   <a href="SourceAdd.aspx" class="btn btn-primary">  Add new</a>

     <a href="Home.aspx" class="btn btn-primary"> Home</a>

&nbsp;<asp:Label ID="lblLabel1" runat="server" Text=""></asp:Label>
</asp:Content>
