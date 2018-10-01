﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFramework_Example.Models
{
    public class NorthWindContext: DbContext
    {
        public NorthWindContext()
            : base("name=NorthWindConnections")
        {

        }

        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }
    }
}