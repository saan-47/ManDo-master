using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ManDo.Models;
using System.Data.Entity;
using System.Data;
namespace ManDo.Controllers

{
    public class HomeController : Controller
    {
        private ClientsEntities cl = new ClientsEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult burgAndRolls()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult SignUp(Table tab)
        {
            if (ModelState.IsValid)
            {
                cl.Tables.Add(tab);
                cl.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public JsonResult validateEmail(string ta)
        {
            return Json(!cl.Tables.Any(user => user.Email == ta), JsonRequestBehavior.AllowGet);
            
        }
        public ActionResult Items()
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