using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using APS_Lab01.Models;

namespace APS_Lab01.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("APS_Lab01")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Product> Products { get; set; }


    }
}