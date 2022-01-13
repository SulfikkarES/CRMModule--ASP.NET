<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/CRMMasteer.Master" AutoEventWireup="true" CodeBehind="Custemer.aspx.cs" Inherits="CRMModule.Custemer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Custemer Details</h2>
    <asp:gridview runat="server" ID="GvCustemer" AutoGenerateColumns="False" CellPadding="10" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="Unnamed1_RowCancelingEdit" OnRowDeleting="Unnamed1_RowDeleting" OnRowEditing="Unnamed1_RowEditing" OnRowUpdating="Unnamed1_RowUpdating" PageSize="25" AllowPaging="True" OnSelectedIndexChanged="GvCustemer_SelectedIndexChanged" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="CustomerId" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerId" />
            <asp:BoundField DataField="FirstName" HeaderText="Fist Name" SortExpression="FirstName" />
            <asp:BoundField DataField="LastNmae" HeaderText="LastName" SortExpression="LastNmae" />
            <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="CollgeName" HeaderText="CollegeName" SortExpression="CollgeName" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="CreatedDate" HeaderText="CreatedDate" SortExpression="CreatedDate" />
            <asp:BoundField DataField="CreatedBy" HeaderText="CreatedBy" SortExpression="CreatedBy" />

            <asp:BoundField DataField="ModifiedDate" HeaderText="ModifieaDate" SortExpression="ModifiedDate" />
            <asp:BoundField DataField="ModifiedBy" HeaderText="ModifidBy" SortExpression="ModifiedBy" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:gridview>
     <a href="CustomerAdd.aspx" class="btn btn-primary">  Add new</a>
    <a href="Home.aspx" class="btn btn-primary">  Home</a>
  
    <br />
    <br />

    

</asp:Content>
