using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views
{
    public partial class Homepage : System.Web.UI.Page
    {
        public List<Product> prodList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["uname"] as string))
            {
                this.Master.LogInOut = "Logout";
            }
            else
            {
                this.Master.LogInOut = "Login/Register";
            }

            //Retrieve top 3 products for display
            if (IsPostBack == false)
            {
                try
                {
                    Product prod = new Product();
                    prodList = prod.GetTop3();

                    dlHome.DataSource = prodList;
                    dlHome.DataBind();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListProduct.aspx");
        }

        protected void dlHome_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("CNHomeViewProd"))
            {
                int pid = Convert.ToInt32(e.CommandArgument);
                Session["PID"] = pid.ToString();

                Response.Redirect("~/Views/ViewProduct.aspx");
            }
        }
    }
}