using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLINQ.Models;
using EntityLINQ.Data;

namespace EntityLINQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexVM bucket = new IndexVM();
            ApplicationDbContext db = new ApplicationDbContext();
            bucket.Customers1 = db.Customers.ToList();
            return View(bucket);
        }

    }
}