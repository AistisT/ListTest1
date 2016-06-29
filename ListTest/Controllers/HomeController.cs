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
        [HttpGet]
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("called constructor in controller");
            Test t = new Test();

            t.list.Add(new DataHolder(1, "hello1"));
            t.list.Add(new DataHolder(2, "hello2"));
            t.list.Add(new DataHolder(3, "hello3"));
            t.list.Add(new DataHolder(4, "hello4"));
            t.list.Add(new DataHolder(5, "hello4"));

            t.random="hi";
            return View(t);
        }

        public void Update(Test t)
        {
            // just passing back to model have no second page :
            t.printValues();
        }

    }
}