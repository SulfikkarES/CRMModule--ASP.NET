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
    public partial class Sources : System.Web.UI.Page
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
            Source catobj = new Source();
            DataTable dtSource;

            dtSource = catobj.GetAllSource();
            GridView1.DataSource = dtSource;
            GridView1.DataBind();

        
                 

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result = 0;
            Source sobj = new Source();
            sobj.SourceId = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[0].Text);
            sobj.SourceName = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text; 
            sobj.CreatedBy = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text; 
           // sobj.CreatedDate = Convert.ToDateTime(GridView1.Rows[e.RowIndex].Cells[0].Text); 
            sobj.ModifiedBy = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text; 
           // sobj.ModifiedDate = Convert.ToDateTime(GridView1.Rows[e.RowIndex].Cells[0].Text);
            result = sobj.EditASource();
            
            if (result > 0)
            {

                lblLabel1.Text = "Successfully updated Source details";
                Response.Redirect("Sources.aspx");

            }
            else
            {

                lblLabel1.Text = "Data not entered";
            }
            FillData();
            GridView1.EditIndex = -1;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int SourceId = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[0].Text);
            Source strobj = new Source ();
            strobj.DeleteASource(SourceId);
            FillData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
           GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillData();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FillData();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Source.aspx");
        }
    }
}