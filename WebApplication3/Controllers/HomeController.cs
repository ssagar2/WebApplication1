using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

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
        public ActionResult LifeStyleImages()
        {
            return View();
        }

        public ActionResult InternalImages1()
        {
            return View();
        }

        public ActionResult InternalImages2()
        {
            return View();
        }

        public ActionResult RegisterUser()
        {
            LoginTable user = new LoginTable();
            return View(user);
        }

        [HttpPost]
        public ActionResult RegisterUser(LoginTable user)
        {
            using (LoginData db = new LoginData()) {
                db.LoginTables.Add(user);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View("UserDashBoard");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorise(LoginTable user)
        {
            using (LoginData db = new LoginData())
            {
                var userDetail = db.LoginTables.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    return View("Login", user);
                }
                else
                {
                    Session["userID"] = user.Id;
                    Session["userName"] = user.UserName;
                    return RedirectToAction("UserDashBoard");
                }
            }

        }
        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

        public ActionResult UserDashBoard()
        {

            return View();
        }

        public ActionResult Test()
        {
            //DbSet<Image> image = new DbSet<Image>();
            using (LoginData db = new LoginData())
            {
                var image = db.Images.Where(x => x.State=="Florida").ToList<Image>();
                return View(image);
            }           
        }
    }
}