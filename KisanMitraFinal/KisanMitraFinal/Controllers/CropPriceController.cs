using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisanMitraFinal.Models;

namespace KisanMitraFinal.Controllers
{
    public class CropPriceController : Controller
    {
        // GET: CropPrices

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CurrentPrice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CurrentPrice(object o)
        {
            KisanMitraDBEntities1 db = new KisanMitraDBEntities1();
            string state = Request.Form["state"];
            string district = Request.Form["district"];
            string block = Request.Form["block"];


            var d = from cp in db.CropPrices
                    where cp.cstate == state && cp.district == district && cp.block == block
                    select cp;
            if (d == null)
            {
                ViewBag.Message = string.Format("No Record Found");
                return RedirectToAction(" CurrentPrice", "CropPrice");
            }
            else
            {
                return View(d);
            }
        }

      

    }
}