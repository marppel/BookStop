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
    public class AccountDAO
    {
        //Insert new account
        public int Insert(Account acnt)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Account (UEmail, UPwd, UName) VALUES (@paraUEmail, @paraUPwd, @paraUName)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraUEmail", acnt.UEmail);
            sqlCmd.Parameters.AddWithValue("@paraUPwd", acnt.UPwd);
            sqlCmd.Parameters.AddWithValue("@paraUName", acnt.UName);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //Retrieve account by email
        public Account RetrieveAccount(string email)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT UName, UPwd, UIsAdmin, UIsDisabled From Account where UEmail = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Account acnt = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string uname = row["UName"].ToString();
                string upwd = row["UPwd"].ToString();
                string Uisadmin = row["UIsAdmin"].ToString();
                string uisdisabled = row["UIsDisabled"].ToString();


                acnt = new Account(uname, upwd, Uisadmin, uisdisabled);

            }
            return acnt;
        }

        //Retrieve profile by email
        public Account RetrieveProfile(string email)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT UName, UEmail, UPostal, UAddress, UCountry From Account WHERE UEmail = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Account acnt = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string uname = row["UName"].ToString();
                string uemail = row["UEmail"].ToString();
                string uaddress = row["UAddress"].ToString();
                string ucountry = row["UCountry"].ToString();
                string upostal = row["UPostal"].ToString();

                acnt = new Account(uname, uemail, upostal, uaddress, ucountry);

            }
            return acnt;
        }

        //Check if account exists
        public Account RetrieveOne(string email)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT UName From Account WHERE UEmail = @paraUEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Account acnt = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string uname = row["UName"].ToString();

                acnt = new Account(uname);

            }
            return acnt;
        }

        //Update account profile
        public int UpdateProfile(Account acnt)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Account SET UName = @paraUName, UPostal = @paraUPostal, UAddress = @paraUAddress, UCountry = @paraUCtry where UEmail =  @paraUEmail";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraUName", acnt.UName);
            sqlCmd.Parameters.AddWithValue("@paraUEmail", acnt.UEmail);
            sqlCmd.Parameters.AddWithValue("@paraUPostal", acnt.UPostal);
            sqlCmd.Parameters.AddWithValue("@paraUAddress", acnt.UAddress);
            sqlCmd.Parameters.AddWithValue("@paraUCtry", acnt.UCountry);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
    }
}