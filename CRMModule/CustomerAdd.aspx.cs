using CRMModule.Compnents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRMModule
{
    public partial class Customer_Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillBoxes();
            }
            btnSubmit.ServerClick += new EventHandler(BtnSubmit_Click);
            btnCancel.ServerClick += new EventHandler(BtnCancel_Click);
   
        }

        void FillBoxes()
        {
            Source srsobj = new Source();
            ddlSource.DataSource =  srsobj.GetAllSource();
            ddlSource.DataTextField = "SourceNmae";
            ddlSource.DataValueField = "SourceId";
            ddlSource.DataBind();

        }

        void BtnSubmit_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            Custemers cobj = new Custemers();
            cobj.FirstName = txtFirstName.Value;
            cobj.LastName = txtLastName.Value;
            cobj.EmailAddress = txtEmail.Value;
            cobj.PhoneNumber = Convert.ToInt32 (txtPhone.Value );
            cobj.Designation = txtDesignation.Value;
            cobj.Company = txtCompany.Value;
            cobj.City = txtCity.Value;
            cobj.CollegeName = txtCollegename.Value;
            cobj.State = txtState.Value;
            cobj.CreatedDate = Convert.ToDateTime (txtCreatedDate.Value);
            cobj.CreatedBy = txtCreatedBy.Value;
            cobj.ModifiedDate = Convert.ToDateTime (txtModifiedDate.Value);
            cobj.ModifiedBy = txtModifiedBy.Value;
            rowsInserted = cobj .InsertACustomer();

            if (rowsInserted > 0)
            {
                ShowMessage("Successfully inserted Custemer details");
                ClearBoxes();
                Response.Redirect("Custemer.aspx");
            }
            else
            {
                ShowMessage("*Data not entered");
            }
        }
        void ShowMessage(string msg)
        {
            txtValidation.InnerText = msg;
        }

        void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        void ClearBoxes()
        {
            txtFirstName.Value = "";
            txtLastName.Value = "";
            txtEmail.Value = "";
            txtPhone.Value = "";
            txtDesignation.Value = "";
            txtCompany.Value = "";
            txtCity.Value = "";
            txtCollegename.Value = "";
            txtState.Value = "";
            txtCreatedDate.Value = "";
            txtCreatedBy.Value = "";
            txtModifiedDate.Value = "";
            txtModifiedBy.Value = "";
            
        }
    }
}