using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework_Example.Models;

namespace EntityFramework_Example.Controllers
{
    public class NorthwindController : Controller
    {
        // GET: Northwind
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}