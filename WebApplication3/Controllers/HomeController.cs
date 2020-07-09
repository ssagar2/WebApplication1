using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Second Page View - Space Query
        public ActionResult SpaceQuery()
        {
            return View();
        }

        //Third Page - part1
        public ActionResult Sticher()
        {
            return View();
        }
    }
}