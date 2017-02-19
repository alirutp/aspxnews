using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string hello()
        {
            return "Hello , how are you!";
        }

        public string Wel(string name, int numTimes = 1)

        {

            return HttpUtility.HtmlEncode("欢迎 " + name + string.Format("，第{0}次来到ASP.NET MVC的世界！ ", numTimes));

        }

        public ActionResult welcome(string name, int num)
        {
            ViewBag.message = name;
            ViewBag.num = num;
            return View();
        }
    }
}