<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/CRMMasteer.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CRMModule.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <h1>Welcome</h1>   
    
    <div class="container">
              <div class="row"></div>
              <div class="col-6">
                  <div class="card" style="width: 18rem;">
  <img src="images/download12121.jfif" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="Customers">Card title</h5>
    <p class="card-text"></p>
    <a href="Custemer.aspx" class="btn btn-primary">Customers</a>
  </div>
</div>
              </div>
              <div class="col-6">
                  <div class="card" style="width: 18rem;">
  <img src="images/Industries1--1-.jpg" class="card-img-top" alt="...">
  <div class="Sources">
    <h5 class="card-title">Card title</h5>
    <p class="card-text"></p>
    <a href="Source.aspx" class="btn btn-primary">Sources</a>
  </div>
</div>


    <br />
     
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><h4>Custemers</h4></asp:LinkButton>
    <br />
      <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"><h4>Sources</h4></asp:LinkButton>
   

</asp:Content>
