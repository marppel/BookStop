using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStop.DAL;

namespace BookStop.BBL
{
    public class Category
    {
        public string ID { get; set; }
        public string Desc { get; set; }
        public int uniqid { get; set; }

        public Category()
        {

        }

        public Category(string desc, int uniqid)
        {
            this.Desc = desc;
            this.uniqid = uniqid;
        }

        public Category(string catid, string desc)
        {
            this.ID = catid;
            this.Desc = desc;
        }

        public Category(int id, string catid, string desc)
        {
            this.uniqid = id;
            this.ID = catid;
            this.Desc = desc;
        }

        //Add new category
        public int AddCategory()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.Insert(this);
        }

        //Get list of all categories in db for ListCategory.aspx
        public List<Category> GetAll()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetAll();
        }

        //Get one category item from db
        public Category RetrieveOne(int id)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.RetrieveOne(id);
        }

        //Update category details in db
        public int UpdateCategory()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.UpdateCategory(this);
        }

        //Delete one category item in db
        public int DeleteCategory(int id)
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.DeleteOne(id);
        }

        //Get list of categories from db for AddItem.aspx & EditItem.aspx
        public List<Category> RetrieveAllCat()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetAllCat();
        }
    }
}