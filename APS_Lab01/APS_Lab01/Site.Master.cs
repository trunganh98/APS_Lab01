using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APS_Lab01.Models;
using System.Data.Entity;

namespace APS_Lab01
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new APS_Lab01.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
        
    }
}