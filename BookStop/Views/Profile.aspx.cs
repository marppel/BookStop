using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (string.IsNullOrEmpty(Session["uname"] as string))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Please login to access this page');window.location ='LoginRegister.aspx';",
                        true);
                    this.Master.LogInOut = "Login/Register";
                }
                else
                {
                    try
                    {
                        this.Master.LogInOut = "Logout";

                        string email = Session["uemail"].ToString();
                        Account acnt = new Account();
                        acnt = acnt.RetrieveProfile(email);

                        if (acnt != null)
                        {
                            txtName.Text = acnt.UName;
                            txtEmail.Text = acnt.UEmail;
                            txtPostal.Text = acnt.UPostal;
                            txtAddress.Text = acnt.UAddress;
                            txtCnty.Text = acnt.UCountry;
                        }
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "alert",
                            "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='HomePage.aspx';",
                            true);
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Update account details
                string uname = txtName.Text;
                string upostal = txtPostal.Text;
                string uaddress = txtAddress.Text;
                string ucountry = txtCnty.Text;
                string uemail = Session["uemail"].ToString();

                Session["uname"] = uname;

                Account acnt = new Account(uname, uemail, upostal, uaddress, ucountry);
                int result = acnt.UpdateProfile();

                if (result == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Profile Updated!');window.location ='Profile.aspx';",
                        true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error occured while updating, please try again.');window.location ='Profile.aspx';",
                    true);
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='Profile.aspx';",
                    true);
            }
        }
    }
}