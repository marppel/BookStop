using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment.Views
{
    public partial class ManageUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"].ToString() != "admin")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('This page is only accessible to Admins');window.location ='HomePage.aspx';",
                    true);
            }
            else
            {
                btnEnable.Enabled = false;
            }

        }

        protected void btnDisable_Click(object sender, EventArgs e)
        {
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
        }
    }
}