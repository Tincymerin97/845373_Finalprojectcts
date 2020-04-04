using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisanMitraFinal.Controllers
{
    public class MerchantController : Controller
    {
        // GET: Merchant
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MerchantRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MerchantRegistration(MerchantDetail buyer)
        {
          KisanMitraDBEntities1 mdb = new KisanMitraDBEntities1();
            if (ModelState.IsValid)
            {
                buyer.merchantname = Request.Form["merchantname"];
                buyer.mobilenumber = long.Parse(Request["mobilenumber"]);
                buyer.address = Request.Form["address"];
                buyer.age = int.Parse(Request["age"]);
                buyer.mstate = Request.Form["state"]; ;
                buyer.block = Request["block"];
                buyer.district = Request["district"];
                buyer.gender = Request.Form["gender"];
                buyer.username = Request.Form["username"];
                buyer.mpassword = Request.Form["password"];

                mdb.MerchantDetails.Add(buyer);
                mdb.SaveChanges();
                return RedirectToAction("Index", "Home");


            }
            return View();
        }

        public ActionResult MerchantDashboard()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MerchantDashboard(Object o)
        {

            return View();
        }

        public ActionResult Farmers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Farmers(object o)
        {
            KisanMitraDBEntities1 db = new KisanMitraDBEntities1();
            string state = Request.Form["state"];
            string district = Request.Form["district"];
            string block = Request.Form["block"];


            var d = from f in db.CropForSells
                    where f.fstate == state && f.district == district &&  f.block == block
                    select f;
            if (d == null)
            {
                ViewBag.Message = string.Format("No Record Found");
                return RedirectToAction("MerchantDashboard", "Merchant");
            }
            else
            {
                return View(d);
            }
        }





      


    }
}