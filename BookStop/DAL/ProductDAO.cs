using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BookStop.BBL;

namespace BookStop.DAL
{
    public class ProductDAO
    {
        //Insert new product
        public int Insert(Product product)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Product (PName, PAuthor, Pdesc, PPrice, PImage, StockQty, ID) VALUES (@paraPName, @paraPAuthor, @paraPCDesc, @paraPPrice, @paraPImage, @paraStkQty, @paraID)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPName", product.PName);
            sqlCmd.Parameters.AddWithValue("@paraPAuthor", product.PAuthor);
            sqlCmd.Parameters.AddWithValue("@paraPCDesc", product.PDesc);
            sqlCmd.Parameters.AddWithValue("@paraPPrice", product.PPrice);
            sqlCmd.Parameters.AddWithValue("@paraPImage", product.filePath);
            sqlCmd.Parameters.AddWithValue("@paraStkQty", product.stkQty);
            sqlCmd.Parameters.AddWithValue("@paraID", product.CatId);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Get list of all products
        public List<Product> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT PID, PName, PAuthor, PDesc, PPrice, StockQty, PImage, CatDesc FROM Product JOIN Category ON  Product.ID = Category.ID";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Product> recList = new List<Product>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int pid = Convert.ToInt32(row["PID"]);
                    string pname = Convert.ToString(row["PName"]);
                    string pauthor = Convert.ToString(row["PAuthor"]);
                    string pdesc = Convert.ToString(row["PDesc"]);
                    decimal pprice = Convert.ToDecimal(row["PPrice"]);
                    int stkqty = Convert.ToInt32(row["StockQty"]);
                    string filepath = Convert.ToString(row["PImage"]);
                    string catdesc = Convert.ToString(row["CatDesc"]);

                    Product prod = new Product(pid, pname, pauthor, pdesc, pprice, stkqty, filepath, catdesc);
                    recList.Add(prod);
                }
            }
            return recList;
        }

        //Get one product by id
        public Product RetrieveOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT PID, PName, PAuthor, PDesc, PPrice, StockQty, PImage, ID FROM Product  WHERE PID = @paraID";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Product prod = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int pid = Convert.ToInt32(row["PID"]);
                string pname = Convert.ToString(row["PName"]);
                string pauthor = Convert.ToString(row["PAuthor"]);
                string pdesc = Convert.ToString(row["PDesc"]);
                decimal pprice = Convert.ToDecimal(row["PPrice"]);
                int stkqty = Convert.ToInt32(row["StockQty"]);
                string filepath = Convert.ToString(row["PImage"]);
                int catid = Convert.ToInt32(row["ID"]);

                prod = new Product(pid, pname, pauthor, pdesc, pprice, stkqty, filepath, catid);

            }
            return prod;
        }

        //Delete one product by id
        public int DeleteOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Product where PID = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraid", id);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Update one product
        public int UpdateProduct(Product prod)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Product SET PName = @paraPName, PDesc = @paraPDesc, PAuthor = @paraPAuthor, PPRice = @paraPPrice, PImage = @paraPImage, StockQty = @paraStkQty, ID = @paraCatID  WHERE PID =  @paraPid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraPName", prod.PName);
            sqlCmd.Parameters.AddWithValue("@paraPDesc", prod.PDesc);
            sqlCmd.Parameters.AddWithValue("@paraPAuthor", prod.PAuthor);
            sqlCmd.Parameters.AddWithValue("@paraPPrice", prod.PPrice);
            sqlCmd.Parameters.AddWithValue("@paraPImage", prod.filePath);
            sqlCmd.Parameters.AddWithValue("@paraStkQty", prod.stkQty);
            sqlCmd.Parameters.AddWithValue("@paraCatID", prod.CatId);
            sqlCmd.Parameters.AddWithValue("@paraPid", prod.PID);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Get top 3 products in db
        public List<Product> GetTop3()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT TOP 3 * FROM Product";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Product> recList = new List<Product>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int pid = Convert.ToInt32(row["PID"]);
                    string pname = Convert.ToString(row["PName"]);
                    string pauthor = Convert.ToString(row["PAuthor"]);
                    decimal pprice = Convert.ToDecimal(row["PPrice"]);
                    string filepath = Convert.ToString(row["PImage"]);

                    Product prod = new Product(pid, pname, pauthor, pprice, filepath);
                    recList.Add(prod);
                }
            }
            return recList;
        }

        public List<Product> SearchFor(string search)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Product WHERE PName LIKE @query OR PAuthor LIKE @query";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@query", "%" + search + "%");

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Product> recList = new List<Product>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int pid = Convert.ToInt32(row["PID"]);
                    string pname = Convert.ToString(row["PName"]);
                    string pauthor = Convert.ToString(row["PAuthor"]);
                    string pdesc = Convert.ToString(row["PDesc"]);
                    decimal pprice = Convert.ToDecimal(row["PPrice"]);
                    int stkqty = Convert.ToInt32(row["StockQty"]);
                    string filepath = Convert.ToString(row["PImage"]);

                    Product prod = new Product(pid, pname, pauthor, pdesc, pprice, stkqty, filepath);
                    recList.Add(prod);
                }
            }
            return recList;
        }

    }
}