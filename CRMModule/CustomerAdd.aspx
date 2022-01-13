<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAdd.aspx.cs" Inherits="CRMModule.Customer_Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AddNewCustomer</title>
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"> 
    <link href="Styles/style.css" rel="stylesheet">
    <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
<script>
$(document).ready(function(){
    $(".toggle").click(function(){
        $(".sidebar").toggleClass("main");
		$(".toggle_ico_hide").toggleClass("main");
		$(".sidebar ul li a").toggleClass("main");
		$(".tr_right_content").toggleClass("main");
		
    }); 
});
</script>
</head>
<body>
<form id="regform" runat="server">
    <br />
     <h3>Add a New Customer</h3>
    <div class="registration-table-container">

			<div class="Form">
			

				<ul>
					<li>
						<label>
							First Name :
						</label>
						<input type="text" id="txtFirstName" runat="server" name="FirstName" />
					</li>
                    <li>
						<label>
							Last Name :
						</label>
						<input type="text" id="txtLastName" runat="server" name="LastName" />
					</li>
                    <li>
						<label>
							Email Address :
						</label>
						<input type="email" id="txtEmail" runat="server" name="Email" />
					</li>
					
                    <li>
						<label>
							Phone Number:
						</label>
						<input type="number" id="txtPhone" runat="server" name="Phone" />
					</li>
                    <li>
						<label>
							Designation :
						</label>
						<input type="text" id="txtDesignation" runat="server" name="Designation" />
					</li>
                    <li>
						<label>
							Company :
						</label>
						<input type="text" id="txtCompany" runat="server" name="Company" />
					</li>
                    <li>
						<label>
							City :
						</label>
						<input type="text" id="txtCity" runat="server" name="City" />
					</li>
                     <li>
						<label>
							College Name :
						</label>
						<input type="text" id="txtCollegename" runat="server" name="CollegeName" />
					</li>
					<li>
						<label>
							State :
						</label>
						<input type="text" id="txtState" runat="server" name="State" />
					</li>
                    <li>
						<label>
							Created Date :
						</label>
						<input type="date" id="txtCreatedDate" runat="server" name="CreatedDate" />
					</li>
                    <li>
						<label>
							Created By :
						</label>
						<input type="text" id="txtCreatedBy" runat="server" name="CreatedBy" />
					</li>
                    <li>
						<label>
							Modified Date :
						</label>
						<input type="date" id="txtModifiedDate" runat="server" name="ModifiedDate" />
					</li>
                    <li>
						<label>
							Modified By :
						</label>
						<input type="text" id="txtModifiedBy" runat="server" name="mo0difiedBy" />
					</li>

					<li>
						<label>
							Source :
						</label>
                      
					<asp:DropDownList ID="ddlSource" runat="server" AutoPostBack="true">
				</asp:DropDownList>
					</li>
                    

					
					<li>
						<label></label>
						<span>
							<input type="button" value="submit" name="submit" id="btnSubmit" runat="server" />
							<input type="button" class="can" value="Cancel" name="cancel" id="btnCancel" runat="server" />
						</span>
					</li>
					<li>
						<label id="txtValidation" runat="server"></label>
                         <br />
    <br />
	     <a href="Custemer.aspx" class="btn btn-primary">  Add new</a>

<a href="Home.aspx" class="btn btn-primary">  Home</a>                       
   

					</li>
				</ul>
			</div>
		</div>
            </form>
        
</body>
</html>
