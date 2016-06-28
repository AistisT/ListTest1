using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListTest.Models;

namespace ListTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Test t = new Test();
            return View(t);
        }
        
        public void Update(Test t)
        {
            // just passing back to model have no second page :
            t.printValues();
        }
    }
}