using CRMModule.Compnents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRMModule
{
    public partial class Custemer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }
        public void FillData()
        {
            Custemers  cusobj = new Custemers();
           

            GvCustemer.DataSource = cusobj.GetAllCustomers();

            GvCustemer.DataBind();


            



        }

        protected void Unnamed1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result;

            Custemers  caobj = new Custemers();
            caobj.FirstName = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            caobj.LastName = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[1])).Text;
            caobj.EmailAddress = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[2])).Text;
            caobj.PhoneNumber = Convert.ToInt32(GvCustemer.Rows[e.RowIndex].Cells[3].Text);
            caobj .Designation = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[4])).Text;
            caobj .Company = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[5])).Text;
            caobj .City = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[6])).Text;
            caobj .CollegeName = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[7])).Text;
            caobj .State = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[8])).Text;
            caobj.CreatedDate = Convert.ToDateTime (GvCustemer.Rows[e.RowIndex].Cells[9].Text); 
            caobj .CreatedBy = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[10])).Text;
            caobj.ModifiedDate = Convert.ToDateTime(GvCustemer.Rows[e.RowIndex].Cells[11].Text); 
            caobj .ModifiedBy = ((TextBox)(GvCustemer.Rows[e.RowIndex].Cells[1].Controls[12])).Text;

            result = caobj.EditACustomer();
            if (result > 0)
            {
                
            
                Response.Redirect("Custemer.aspx");
               
            }
            else
            {
           
               
            }
            FillData();
            GvCustemer.EditIndex = -1;
        }
        
        protected void Unnamed1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvCustemer.EditIndex = e.NewEditIndex;
        }

        protected void Unnamed1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int CustemerId = Convert.ToInt32(GvCustemer.Rows[e.RowIndex].Cells[0].Text);
            Custemers strobj = new Custemers();
            strobj.DeleteACustomer(CustemerId);
            FillData();

        }

        protected void Unnamed1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvCustemer.EditIndex = -1;
            FillData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer Add.aspx");
        }

        protected void GvCustemer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FillData();
            GvCustemer.PageIndex = e.NewPageIndex;
            GvCustemer.DataBind();
        }

        protected void GvCustemer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}