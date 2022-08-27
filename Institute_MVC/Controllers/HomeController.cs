using Institute_MVC.Core;
using Institute_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Institute_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Account()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Account(Account account)
        {
            var myData = new BasicDetails();
            myData.accountDetails = new Account();
            myData.accountDetails = account;

            TempData["basicDetails"] = myData;
            return RedirectToAction("Payment");
        }

        public ActionResult Personal()
        {
           return View();
        }
        [HttpPost]
        public ActionResult Personal(Personal personal)
        {
            var myData = new BasicDetails();
            myData = (BasicDetails)TempData["basicDetails"];

            myData.personalDetails = new Personal();
            myData.personalDetails = personal;

            //TempData["basicDetails"] = myData;
            return RedirectToAction("Payment");
        }

        public ActionResult Payment()
        {
            

            return View();
        }
        public ActionResult Finish()
        {
            

            return View();
        }
    }
}