using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using BookStop.BBL;

namespace WebAssignment.Views.Admin
{
    public partial class AddItem : System.Web.UI.Page
    {
        public List<Category> categories;
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
                        //Retrieve all categories to bind to dropdownlist
                        Category cat = new Category();
                        categories = cat.RetrieveAllCat();

                        ddlCat.Items.Clear();
                        ddlCat.Items.Insert(0, new ListItem("--Select--", "0"));
                        ddlCat.AppendDataBoundItems = true;
                        ddlCat.DataTextField = "Desc";
                        ddlCat.DataValueField = "uniqid";
                        ddlCat.DataSource = categories;
                        ddlCat.DataBind();
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "alert",
                            "alert('There are currently no categories. Please create a category before adding products.');window.location ='AddItem.aspx';",
                            true);
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ListItem.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Retrieve all field text items
                string bkName = txtPName.Text;
                string bkAuthor = txtPAuthor.Text;
                string bkDesc = txtPDesc.Text;
                decimal bkPrice = Convert.ToDecimal(txtPPrice.Text);
                int stkQty = Convert.ToInt32(txtStockQty.Text);
                int cat = int.Parse(ddlCat.SelectedValue);

                //Create folder and file paths
                var folder = Server.MapPath("~/uploads/");
                string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
                string filePath = "~/uploads/" + fileName;

                imgName.Text = fileName.ToString();

                //create new directory for product images
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    //click 'Show All Files' to find folder

                }
                FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

                //Initialise new Product object and add to db
                Product pd = new Product(bkName, bkAuthor, bkDesc, bkPrice, stkQty, cat, filePath);
                int result = pd.AddProduct();

                if (result == 1) //add successful
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('New product added successfully!');window.location ='ListItem.aspx';",
                        true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('An error occured while adding product, please try again');window.location ='ListItem.aspx';",
                        true);
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='AddItem.aspx';",
                    true);
            }

        }
    }
}