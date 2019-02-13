using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        //query string and the url will be http://localhost:49846/home/index/10?name=sany&&department=it
        //public string Index(string id,string name, string department)
        //{
        //    return "Hello from sany, the id= " + id+ " and the name= "+ name + " the department= "+ department;
        //}

        //another way for query string and the url will be http://localhost:49846/home/index/10?name=sany&&department=it
        //public string Index(string id)
        //{
        //    return "Hello from sany, the id= " + id + " and the name= " + Request.QueryString["name"] + " the department= " + Request.QueryString["department"] ;
        //}

        public ActionResult Index()
        {
            ViewBag.Message = "Your application home page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.Countries =  new List<string>()
            {
                "Egypt",
                "USA",
                "Canda"
            };

            return View();
        }
    }
}