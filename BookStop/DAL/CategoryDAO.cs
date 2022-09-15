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
    public class CategoryDAO
    {
        //Insert new category
        public int Insert(Category cat)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Category (CatID, CatDesc) VALUES (@paraCID, @paraCDesc)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraCID", cat.ID);
            sqlCmd.Parameters.AddWithValue("@paraCDesc", cat.Desc);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Get all categories (id, catid, catdesc)
        public List<Category> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Category";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Category> recList = new List<Category>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    string catid = Convert.ToString(row["CatID"]);
                    string catdesc = Convert.ToString(row["CatDesc"]);
                    Category categories = new Category(id, catid, catdesc);
                    recList.Add(categories);
                }
            }
            return recList;
        }

        //Get one cateogry
        public Category RetrieveOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT CatID, CatDesc, ID From Category where ID = @paraID";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Category cat = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string catid = row["CatID"].ToString();
                string catdesc = row["CatDesc"].ToString();
                int uniqid = Convert.ToInt32(row["ID"]);

                cat = new Category(uniqid, catid, catdesc);

            }
            return cat;
        }

        //Update one category
        public int UpdateCategory(Category cat)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Category SET CatID = @paraCID, CatDesc = @paraCDesc WHERE ID =  @parauniqid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraCID", cat.ID);
            sqlCmd.Parameters.AddWithValue("@paraCDesc", cat.Desc);
            sqlCmd.Parameters.AddWithValue("@parauniqid", cat.uniqid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Delete one category
        public int DeleteOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Category where id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraid", id);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Get all category (id, catdesc)
        public List<Category> GetAllCat()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT CatDesc, ID FROM Category";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Category> recList = new List<Category>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int uniqid = Convert.ToInt32(row["ID"]);
                    string catdesc = Convert.ToString(row["CatDesc"]);
                    Category categories = new Category(catdesc, uniqid);
                    recList.Add(categories);
                }
            }
            return recList;
        }
    }
}