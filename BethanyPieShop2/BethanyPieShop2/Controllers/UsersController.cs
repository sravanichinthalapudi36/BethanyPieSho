using BethanyPieShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BethanyPieShop2.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private DbContextClass db = new DbContextClass();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult Register(Register re)
        //{
        //    if(ModelState.IsValid)
        //    {

        //    }
        //    return View();
        //}





        [HttpPost]
        public ActionResult Index(Register s)
        {

            var credentials = db.Registers.Where(model => model.EmailId == s.EmailId && model.Password == s.Password).FirstOrDefault();
            if (credentials == null)
            {
                ViewBag.ErrorMessage = "Login Failed";
                return View();
            }
            else
            {
                Session["username"] = credentials.FName;

                return RedirectToAction("Index", "Home");
            }


        }


        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Users");
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Register d)
        {
            if (ModelState.IsValid == true)
            {
                db.Registers.Add(d);
                int registerD = db.SaveChanges();
                if (registerD > 0)
                {
                    ViewBag.Message = "<script>alert('Data is submitted')</script>";
                    ModelState.Clear();
                }
                else
                {
                    TempData["Message"] = "Data not submitted";
                }


            }


            return View();
        }
    }
}