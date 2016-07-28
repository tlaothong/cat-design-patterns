using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreDIWeb.Controllers
{
    public class HomeController : Controller
    {
        Services.MyClassDi myDi;

        public HomeController(Services.MyClassDi myDi)
        {
            this.myDi = myDi;
        }

        public IActionResult Index()
        {
            ViewData["MyProperty"] = this.myDi.Property;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
