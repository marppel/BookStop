using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment.Views
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["uname"] as string))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Please login to access this page');window.location ='LoginRegister.aspx';",
                    true);
                this.Master.UAcntName = "Account";
                this.Master.LogInOut = "Login/Register";
            }
            else
            {
                this.Master.UAcntName = Session["uname"].ToString();
                this.Master.LogInOut = "Logout";
            }
        }

        protected void btnCheckout2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfirmPayment.aspx");
        }

        protected void btnContShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}