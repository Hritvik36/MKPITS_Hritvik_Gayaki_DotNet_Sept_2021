using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Exa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.studentName = new List<student>()
            {
                new student {Firstname ="Hritvik",Lastname ="Gayaki"};
            new student { Firstname = "Akash", Lastname = "Narwade" };
            new student { Firstname = "kunal", Lastname = "Barmate" };
            new student { Firstname = "Ritik", Lastname = "Titamare" };

        }
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
        public ActionResult MyPage()
        {
            ViewBag.Message = "This my first web page.";

            return View();
        }
    }
}