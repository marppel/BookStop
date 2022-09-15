using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views.Admin
{
    public partial class ViewItem : System.Web.UI.Page
    {
        public List<Product> prodList;
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
                    try
                    {
                        //Retrieve all products
                        Product pd = new Product();
                        prodList = pd.GetAll();

                        if (prodList != null)
                        {
                            //Populate Gridview with data
                            GVProduct.DataSource = prodList;
                            GVProduct.DataBind();
                        }
                        else
                        {
                            lblNoItem.Text = "There are no items to display. Click the Add button to add an item.";
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

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AddItem.aspx");
        }

        protected void GVProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected row
            GridViewRow row = GVProduct.SelectedRow;

            //Set session ID for retrieving edit details on edit page;
            Session["prodID"] = row.Cells[0].Text;
            Response.Redirect("~/Views/Admin/EditItem.aspx");
        }

        protected void GVProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Retrieve Prod ID from row
            int id = Convert.ToInt32(GVProduct.DataKeys[e.RowIndex].Value);

            //Delete row using ID
            Product prod = new Product();
            int result = prod.DeleteProduct(id);

            try
            {
                if (result == 1) //if successful
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Product Deleted');window.location ='ListItem.aspx';",
                        true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('An error occured while deleting. Please try again.');window.location ='ListItem.aspx';",
                        true);
                }
            }
            catch //for uncaught errors in code
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='ListItem.aspx';",
                    true);
            }

        }
    }
}