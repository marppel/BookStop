using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStop.DAL;

namespace BookStop.BBL
{
    public class Product
    {
        public int PID { get; set; }
        public string PName { get; set; }
        public string PAuthor { get; set; }
        public string PDesc { get; set; }
        public decimal PPrice { get; set; }
        public int stkQty { get; set; }
        public int CatId { get; set; }
        public string filePath { get; set; }

        public string CatDesc { get; set; }

        public Product()
        {

        }

        public Product(string pname, string pauthor, string pdesc, decimal pprice, int stkqty, int catid, string filepath)
        {
            this.PName = pname;
            this.PAuthor = pauthor;
            this.PDesc = pdesc;
            this.PPrice = pprice;
            this.stkQty = stkqty;
            this.CatId = catid;
            this.filePath = filepath;
        }

        public Product(int pid, string pname, string pauthor, string pdesc, decimal pprice, int stkqty, string filepath, string catdesc)
        {
            this.PID = pid;
            this.PName = pname;
            this.PAuthor = pauthor;
            this.PDesc = pdesc;
            this.PPrice = pprice;
            this.stkQty = stkqty;
            this.filePath = filepath;
            this.CatDesc = catdesc;
        }
        public Product(int pid, string pname, string pauthor, string pdesc, decimal pprice, int stkqty, string filepath, int catid)
        {
            this.PID = pid;
            this.PName = pname;
            this.PAuthor = pauthor;
            this.PDesc = pdesc;
            this.PPrice = pprice;
            this.stkQty = stkqty;
            this.filePath = filepath;
            this.CatId = catid;  
        }

        public Product(int pid, string pname, string pauthor, string pdesc, decimal pprice, int stkqty, string filepath)
        {
            this.PID = pid;
            this.PName = pname;
            this.PAuthor = pauthor;
            this.PDesc = pdesc;
            this.PPrice = pprice;
            this.stkQty = stkqty;
            this.filePath = filepath;
        }

        public Product(int pid, string pname, string pauthor, decimal pprice, string filepath)
        {
            this.PID = pid;
            this.PName = pname;
            this.PAuthor = pauthor;
            this.PPrice = pprice;
            this.filePath = filepath;
        }

        //Add new product
        public int AddProduct()
        {
            ProductDAO dao = new ProductDAO();
            return dao.Insert(this);
        }

        //Get list of all products in db
        public List<Product> GetAll()
        {
            ProductDAO dao = new ProductDAO();
            return dao.GetAll();
        }

        //Delete one product by id
        public int DeleteProduct(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.DeleteOne(id);
        }

        //Get one product by id
        public Product RetrieveOne(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.RetrieveOne(id);
        }

        //Update product 
        public int UpdateProduct()
        {
            ProductDAO dao = new ProductDAO();
            return dao.UpdateProduct(this);
        }

        //Get top 3 products from db
        public List<Product> GetTop3()
        {
            ProductDAO dao = new ProductDAO();
            return dao.GetTop3();
        }

        public List<Product> Search(string search)
        {
            ProductDAO dao = new ProductDAO();
            return dao.SearchFor(search);
        }
    }
}