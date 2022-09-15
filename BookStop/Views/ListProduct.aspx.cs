using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views
{
    public partial class ListProduct : System.Web.UI.Page
    {
        public List<Category> catlist;
        public List<Product> prodlist;
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

            //Retrieve all products and categories for display
            if (IsPostBack == false)
            {
                try
                {
                    Category cat = new Category();
                    catlist = cat.RetrieveAllCat();
                    dlViewCat.DataSource = catlist;
                    dlViewCat.DataBind();

                    Product prod = new Product();
                    prodlist = prod.GetAll();
                    dlViewProd.DataSource = prodlist;
                    dlViewProd.DataBind();

                    totalRslt.InnerText = prodlist.Count().ToString();
                }
                catch
                {
                    lblEmpty.Text = "There are currently no items in the shop";
                }
            }
        }

        protected void dlViewProd_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("CNViewProd"))
            {
                int pid = Convert.ToInt32(e.CommandArgument);
                Session["PID"] = pid.ToString();

                Response.Redirect("~/Views/ViewProduct.aspx");
            }
        }
    }
}