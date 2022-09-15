using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment
{
    public partial class NavbarNoLog : System.Web.UI.MasterPage
    {

        public string UAcntName
        {
            get
            {
                return lblUAcntName.Text;
            }
            set
            {
                lblUAcntName.Text = value;
            }
        }

        public string LogInOut
        {
            get
            {
                return LBLogInOut.Text;
            }
            set
            {
                LBLogInOut.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListProduct.aspx");
        }

        protected void LBLogInOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginRegister.aspx");
        }
    }
}