using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views
{
    public partial class LoginRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Check field validation
            if (txtEmail.Text == "" && txtPwd.Text == "")
            {
                lblErrLogin.Text = "Please enter your email and password";
                lblErrLogin.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtEmail.Text == "")
            {
                lblErrLogin.Text = "Please enter your email";
                lblErrLogin.ForeColor = System.Drawing.Color.Red;
            }
            else if(txtPwd.Text == "")
            {
                lblErrLogin.Text = "Please enter your password";
                lblErrLogin.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    //Check account validation for login
                    string email = txtEmail.Text;
                    string pwd = txtPwd.Text;

                    Account acnt = new Account();
                    acnt = acnt.RetrieveAccount(email);

                    if (acnt == null)
                    {
                        lblErrLogin.Text = "This email has not been registered to an account. Please register your account.";
                        lblErrLogin.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (acnt.IsDisabled.ToUpper() == "D")
                    {
                        lblErrLogin.Text = "Your account has been disabled. Please contact the admin for help.";
                        lblErrRegister.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (acnt.IsAdmin == "Y" && acnt.UPwd == pwd)
                    {
                        Session["uname"] = "admin";
                        Response.Redirect("../Views/Admin/AdminHomepage.aspx");
                    }
                    else if (acnt.IsAdmin == "N" && acnt.UPwd == pwd)
                    {
                        Session["uname"] = acnt.UName;
                        Session["uemail"] = email;
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                    {
                        lblErrLogin.Text = "Password Incorrect. Please try again";
                        lblErrLogin.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch
                {
                    lblErrLogin.Text = "An error has occured while logging in. Please contact the developers to fix this issue.";
                    lblErrLogin.ForeColor = System.Drawing.Color.Red;
                }
            }       
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Check text validation
            if (txtNewEmail.Text == "" && txtNewPwd.Text == "" && txtNewName.Text == "")
            {
                lblErrRegister.Text = "Please enter your username, email and password";
                lblErrRegister.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtNewName.Text == "")
            {
                lblErrRegister.Text = "Please enter your username";
                lblErrRegister.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtNewEmail.Text == "")
            {
                lblErrRegister.Text = "Please enter your email";
                lblErrRegister.ForeColor = System.Drawing.Color.Red;
            }

            else if (txtNewPwd.Text == "")
            {
                lblErrRegister.Text = "Please enter your password";
                lblErrRegister.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    //Create new account
                    string newEmail = txtNewEmail.Text;
                    string newPwd = txtNewPwd.Text;
                    string newUName = txtNewName.Text;

                    Account chkacnt = new Account();
                    chkacnt = chkacnt.RetrieveOne(newEmail);

                    if (chkacnt == null)
                    {
                        Account acnt = new Account(newEmail, newPwd, newUName);
                        int result = acnt.AddAccount();

                        if (result == 1)
                        {
                            lblErrLogin.Text = "Registration complete, please sign in:";
                            lblErrLogin.ForeColor = System.Drawing.Color.Green;
                            RegularExpressionValidator1.Visible = false;

                            txtNewEmail.Text = "";
                            txtNewPwd.Text = "";
                            txtNewName.Text = "";
                        }
                        else
                        {
                            lblErrRegister.Text = "An error occured while registering user, please try again.";
                            lblErrLogin.ForeColor = System.Drawing.Color.Red;
                            RegularExpressionValidator1.Visible = false;
                        }
                    }
                    else
                    {
                        lblErrRegister.Text = "This email account has already been registered.";
                        lblErrLogin.ForeColor = System.Drawing.Color.Red;
                        RegularExpressionValidator1.Visible = false;
                    }
                }
                catch
                {
                    lblErrRegister.Text = "An error has occured while logging in. Please contact the developers to fix this issue.";
                    lblErrLogin.ForeColor = System.Drawing.Color.Red;
                    RegularExpressionValidator1.Visible = false;
                }            
            }
        }
    }
}