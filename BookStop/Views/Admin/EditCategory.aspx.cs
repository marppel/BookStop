using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views.Admin
{
    public partial class EditCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
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
                    try
                    {
                        //Retrieve category details 
                        int id = Convert.ToInt32(Session["ID"]);

                        Category cat = new Category();
                        cat = cat.RetrieveOne(id);

                        txtID.Text = cat.ID;
                        txtDesc.Text = cat.Desc;
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "alert",
                            "alert('This page is not accessible via URL. To view this page, please access this through provided Admin features');window.location ='ListCategory.aspx';",
                            true);
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Get text field items and update category
                string catid = txtID.Text;
                string desc = txtDesc.Text;
                int id = Convert.ToInt32(Session["ID"]);

                Category cat = new Category(id, catid, desc);
                int result = cat.UpdateCategory();

                if (result == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Edit Successful!');window.location ='ListCategory.aspx';",
                        true);
                }
                else
                {
                    lblCatEditErr.Text = "An error occured while adding a new category. Please try again.";
                    lblCatEditErr.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');",
                    true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ListCategory.aspx");
        }
    }
}