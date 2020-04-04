using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisanMitraFinal.Models
{
    public class CropForSell
    {
        [Required]
        public string FarmerName { set; get; }
        [Required]

        public long MobileNumber { set; get; }
        [Required]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Block { get; set; }
        [Required]
        public string Commodity { set; get; }
        [Required]
        public string Season { set; get; }
        [Required]
        public double AmountOfCommodity { set; get; }
    }
}