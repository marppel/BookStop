using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views.Admin
{
    public partial class AddCategory : System.Web.UI.Page
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
                if (IsPostBack == false)
                {
                    txtDesc.Text = "";
                    txtID.Text = "";
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get text fields and add new category
                string txtCatID = txtID.Text;
                string txtCatDesc = txtDesc.Text;

                Category cat = new Category(txtCatID, txtCatDesc);

                int result = cat.AddCategory();

                if (result == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('New Category Added!');window.location ='ListCategory.aspx';",
                        true);
                }
                else
                {
                    lblCatAddErr.Text = "An error occured while adding a new category. Please try again.";
                    lblCatAddErr.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='AddCategory.aspx';",
                    true);
            }


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ListCategory.aspx");
        }
    }
}