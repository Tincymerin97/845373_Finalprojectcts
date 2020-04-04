using KisanMitraFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisanMitraFinal.Controllers
{
    public class FarmerController : Controller
    {
        // GET: Farmer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FarmerDashboard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FarmerDashboard(object o)
        {

            return View();
        }
        public ActionResult Merchants()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Merchants(object o)
        {
            KisanMitraDBEntities1 db = new KisanMitraDBEntities1();
            string state = Request.Form["state"];
            string district = Request.Form["district"];
            string block = Request.Form["block"];


            var d = from m in db.MerchantDetails
                    where m.mstate == state && m.district == district && m.block == block
                    select m;
            if (d == null)
            {
                ViewBag.Message = string.Format("No Record Found");
                return RedirectToAction(" FarmerDashboard", "Farmer");
            }
            else
            {
                return View(d);
            }
        }

        
        

        public ActionResult FarmerRegistration()
        {
            return View();
        }

        [HttpPost]

        public ActionResult FarmerRegistration(FarmerDetail farmer)
        {

            KisanMitraDBEntities1 mdb = new KisanMitraDBEntities1();
            if (ModelState.IsValid)
            {
                farmer.farmername = Request["farmername"];
                farmer.mobilenumber = long.Parse(Request["mobilenumber"]);
                farmer.age = int.Parse(Request["age"]);
                farmer.fstate = Request.Form["state"];
                farmer.block= Request["block"];
                farmer.district = Request["district"];
                farmer.gender = Request.Form["gender"];
                farmer.username = Request.Form["username"];
                farmer.fpassword = Request.Form["password"];
                
                mdb.FarmerDetails.Add(farmer);
                mdb.SaveChanges();
               
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult CropForSell()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CropForSell(CropForSell cf)
        {

            KisanMitraDBEntities1 mdb = new KisanMitraDBEntities1();
            if (ModelState.IsValid)
            {
                cf.commodity = Request["commodity"];
                cf.farmername = Request["farmername"];
                cf.mobilenumber= long.Parse(Request["mobilenumber"]);
                cf.season = Request.Form["season"];
                cf.fstate = Request.Form["fstate"];
                cf.block = Request["block"];
                cf.amountOfCommodity = float.Parse(Request["amountOfCommodity"]);
                cf.district = Request["district"];

                mdb.CropForSells.Add(cf);
                mdb.SaveChanges();

                return RedirectToAction("FarmerDashboard", "Farmer");
            }

            return View();
        }

    }
}