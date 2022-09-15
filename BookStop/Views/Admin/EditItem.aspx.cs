using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStop.BBL;
using System.IO;

namespace WebAssignment.Views.Admin
{
    public partial class EditItem : System.Web.UI.Page
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
                        //Bind category items to dropdownlist
                        Category cat = new Category();
                        categories = cat.RetrieveAllCat();

                        ddlCat.Items.Clear();
                        ddlCat.Items.Insert(0, new ListItem("--Select--", "0"));
                        ddlCat.AppendDataBoundItems = true;
                        ddlCat.DataTextField = "Desc";
                        ddlCat.DataValueField = "uniqid";
                        ddlCat.DataSource = categories;
                        ddlCat.DataBind();

                        //Retrieve prod ID and prod details into display
                        int id = Convert.ToInt32(Session["ProdID"]);
                        Product prod = new Product();
                        prod = prod.RetrieveOne(id);

                        txtPName.Text = prod.PName;
                        txtPAuthor.Text = prod.PAuthor;
                        txtPDesc.Text = prod.PDesc;
                        txtPPrice.Text = prod.PPrice.ToString();
                        txtStockQty.Text = prod.stkQty.ToString();
                        ddlCat.SelectedValue = prod.CatId.ToString();
                        imgName.Text = prod.filePath;
                        PImage.Attributes["src"] = ResolveUrl(prod.filePath);
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "alert",
                            "alert('This page is not accessible via URL. To view this page, please access this through provided Admin features');window.location ='ListItems.aspx';",
                            true);
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ListItem.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Retrieve text fields
                int pid = Convert.ToInt32(Session["ProdID"]);
                string bkName = txtPName.Text;
                string bkAuthor = txtPAuthor.Text;
                string bkDesc = txtPDesc.Text;
                decimal bkPrice = Convert.ToDecimal(txtPPrice.Text);
                int stkQty = Convert.ToInt32(txtStockQty.Text);
                int cat = int.Parse(ddlCat.SelectedValue);

                //create folder to store images
                var folder = Server.MapPath("~/uploads");
                string fileName;
                string filePath;

                //Retrieve uploaded file and create file mapping
                if (FileUpload.HasFile)
                {
                    fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
                    filePath = "~/uploads/" + fileName;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                }
                else //If there is no file uploaded, get existing image file name and map it to Image folder
                {
                    fileName = imgName.Text;
                    filePath = "~/uploads/" + fileName;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);

                    }
                }
                //Save Image file into Image folder
                FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

                //Update product
                Product pd = new Product(pid, bkName, bkAuthor, bkDesc, bkPrice, stkQty, filePath, cat);
                int result = pd.UpdateProduct();

                if (result == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Product updated successfully!');window.location ='ListItem.aspx';",
                        true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('An error occured while updating product details, please try again');window.location ='ListItem.aspx';",
                        true);
                }

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('An error has occured. Please contact the developers to fix this issue.');window.location ='EditItems.aspx';",
                    true);
            }
        }
    }
}