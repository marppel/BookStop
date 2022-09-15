using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views.Admin
{
    public partial class ListCategory : System.Web.UI.Page
    {
        public List<Category> catList;
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
                try
                {
                    if (IsPostBack == false)
                    {
                        //Retrieve all categories
                        Category cat = new Category();
                        catList = cat.GetAll();

                        if (catList != null)
                        {
                            //Populate Gridview with data
                            GVCategory.DataSource = catList;
                            GVCategory.DataBind();
                        }
                        else
                        {
                            lblNoItem.Text = "There are no items to display. Click the Add button to add an item.";
                        }


                        //DLCategory.DataSource = catList;
                        //DLCategory.DataBind();
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
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AddCategory.aspx");
        }

        protected void GVCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Retrieve catID from row 
            int id = Convert.ToInt32(GVCategory.DataKeys[e.RowIndex].Value);

            //Delete row using ID
            Category cat = new Category();
            int result = cat.DeleteCategory(id);

            try
            {
                if (result == 1) //if successful
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Category Deleted');window.location ='ListCategory.aspx';",
                        true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('An error occured while deleting. Please try again.');window.location ='ListCategory.aspx';",
                        true);
                }
            }
            catch //for uncaught errors in code
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='ListCategory.aspx';",
                    true);
            }
        }

        protected void GVCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected row
            GridViewRow row = GVCategory.SelectedRow;

            //Set session ID for retrieving edit details on edit page
            Session["ID"] = row.Cells[0].Text;
            Response.Redirect("~/Views/Admin/EditCategory.aspx");
        }
    }
}