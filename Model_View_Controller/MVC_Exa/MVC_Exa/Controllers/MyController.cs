using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Exa.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewData["Name"] = "Hritvik";
            ViewBag.role = "Shree Medical";
            ViewBag.Message = "This my first web page.";
            return View();
        }
        
    }
}