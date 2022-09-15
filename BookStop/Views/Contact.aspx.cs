using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment.Views
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["uname"] as string))
            {
                this.Master.UAcntName = Session["uname"].ToString();
                this.Master.LogInOut = "Logout";
            }
            else
            {
                this.Master.UAcntName = "Account";
                this.Master.LogInOut = "Login/Register";
            }
        }
    }
}