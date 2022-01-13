using CRMModule.Compnents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRMModule
{
    public partial class SourceAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            btnSubmit.ServerClick += new EventHandler(BtnSubmit_Click);
            btnCancel.ServerClick += new EventHandler(BtnCancel_Click);
        }
        void BtnSubmit_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            Source sobj = new Source();
            sobj.SourceName = txtSourcename.Value;
            sobj.CreatedDate = Convert.ToDateTime(txtCreatedDate .Value) ;
            sobj.CreatedBy =txtCreatedBy.Value;
            sobj.ModifiedDate = Convert .ToDateTime (txtModifiedDate .Value);
            sobj.ModifiedBy = txtModifiedBy.Value;
            rowsInserted = sobj.InsertASource();

            if (rowsInserted > 0)
            {
                ShowMessage("Successfully inserted Source details");
                ClearBoxes();
                Response.Redirect("Source.aspx");
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
            txtSourcename.Value = "";
            txtCreatedBy.Value = "";
            txtCreatedDate.Value = "";
            txtModifiedDate.Value = " ";
            txtModifiedBy.Value = "";
        }
    }
}