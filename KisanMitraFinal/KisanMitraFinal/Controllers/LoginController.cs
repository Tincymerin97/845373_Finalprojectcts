using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisanMitraFinal.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        // farmer login
        public ActionResult FarmerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FarmerLogin(Object o)
        {
            string user = Request.Form["username"];
            string pass = Request.Form["password"];

            KisanMitraDBEntities1 mdb = new KisanMitraDBEntities1();
            var farmer = mdb.FarmerDetails.Where(f => f.username.Equals(user)).FirstOrDefault();

            if (farmer == null)
            {
                ViewBag.Message = "Account not founded, Register first.";
                return RedirectToAction("FarmerLogin", "Login");
            }
            else if (farmer.username.Equals(user) && farmer.fpassword.Equals(pass))
            {
                ViewBag.Message = "Login Successfuly";
                return RedirectToAction("FarmerDashboard", "Farmer");
            }
            else
            {
                ViewBag.Message = "Incorrect username/password";
                return RedirectToAction("FarmerLogin", "Login");

            }
        }


        //  Merchant login
        public ActionResult MerchantLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MerchantLogin(Object o)
        {

            string user = Request.Form["username"];
            string pass = Request.Form["password"];

            KisanMitraDBEntities1 mdb = new KisanMitraDBEntities1();
            var buyer = mdb.MerchantDetails.Where(f => f.username.Equals(user)).FirstOrDefault();

            if (buyer == null)
            {
                ViewBag.Message = "Account not founded, Register first.";
                return RedirectToAction("MerchantLogin", "Login");
            }
            else if (buyer.username.Equals(user) && buyer.mpassword.Equals(pass))
            {
                ViewBag.Message = "Login Successfuly";
                return RedirectToAction("MerchantDashboard", "Merchant");
            }
            else
            {
                ViewBag.Message = "Incorrect username/password";
                return RedirectToAction("MerchantLogin", "Login");

            }
        }

      
    }
}

