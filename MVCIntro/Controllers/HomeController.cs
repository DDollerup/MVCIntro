using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIntro.Models.BaseModels;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Home home = new Home();
            home.HomeID = 1;
            home.Text = "Welcome to my first MVC application!";
            home.Image = "Cookie.png";

            return View(home);
        }

        public ActionResult About()
        {
            About about = new About();
            about.AboutID = 1;
            about.Text = "I'm a guy, that makes MVC Applications";
            about.Image = "N/A";

            return View(about);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}