using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class NavbarAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListItem.aspx");
        }

        protected void LBLogInOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Logging out');window.location ='LoginRegister.aspx';",
                    true);
        }
    }
}