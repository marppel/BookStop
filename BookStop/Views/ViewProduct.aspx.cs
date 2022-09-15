using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;

namespace WebAssignment.Views
{
    public partial class ViewProduct : System.Web.UI.Page
    {
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

            //Get ViewProductId from session and retrieve respective product details
            if (IsPostBack == false)
            {
                try
                {
                    int pid = Convert.ToInt32(Session["PID"]);

                    Product prod = new Product();
                    prod = prod.RetrieveOne(pid);

                    if (prod != null)
                    {
                        lblName.Text = prod.PName;
                        lblAuthor.Text = prod.PAuthor;
                        lblDesc.Text = prod.PDesc;
                        lblQty.Text = prod.stkQty.ToString();
                        lblPrice.Text = prod.PPrice.ToString();
                        PImage.Attributes["src"] = ResolveUrl(prod.filePath);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "alert",
                            "alert('Product details unaccessible.');window.location ='ListProduct.aspx';",
                            true);
                    }
                }
                catch
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('This page is not accessible via URL. To view this page.');window.location ='ListProduct.aspx';",
                        true);
                }

            }
        }
    }
}