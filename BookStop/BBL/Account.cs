using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStop.DAL;

namespace BookStop.BBL
{
    public class Account
    {
        public string UEmail { get; set; }
        public string UPwd { get; set; }
        public string UName { get; set; }
        public string IsAdmin { get; set; }
        public string IsDisabled { get; set; }
        public string UPostal { get; set; }
        public string UAddress { get; set; }
        public string UCountry { get; set; }


        public Account()
        {

        }

        public Account(string name)
        {
            this.UName = name;
        }
        public Account(string email, string pwd, string uname)
        {
            this.UEmail = email;
            this.UPwd = pwd;
            this.UName = uname;
        }

        public Account(string name, string pwd, string isadmin, string isdisabled)
        {
            this.UName = name;
            this.UPwd = pwd;
            this.IsAdmin = isadmin;
            this.IsDisabled = isdisabled;
        }

        public Account(string name, string email, string postal, string address, string country)
        {
            this.UName = name;
            this.UEmail = email;
            this.UPostal = postal;
            this.UAddress = address;
            this.UCountry = country;
        }

        //Add new account
        public int AddAccount()
        {
            AccountDAO dao = new AccountDAO();
            return dao.Insert(this);
        }

        //Get account by email
        public Account RetrieveAccount(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.RetrieveAccount(email);
        }

        //Get account profile by email
        public Account RetrieveProfile(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.RetrieveProfile(email);
        }

        //Check if account exists by retriving one
        public Account RetrieveOne(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.RetrieveOne(email);
        }

        //Updating account profile
        public int UpdateProfile()
        {
            AccountDAO dao = new AccountDAO();
            return dao.UpdateProfile(this);
        }
    }
}