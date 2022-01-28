using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropDownStudy.Controllers
{
    public class HomeController : Controller
    {
        List<SelectListItem> myskills = new List<SelectListItem>()
        {
            new SelectListItem{Text="Asp.Net",Value="1"},
             new SelectListItem{Text="Asp.Net MVC",Value="2"},
              new SelectListItem{Text="Angular JS",Value="3"},
               new SelectListItem{Text="LINQ",Value="4"},

        };
        Vie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}