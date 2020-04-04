using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisanMitraFinal.Models
{
    public class CropPrices
    {
        [Required]
        public string Commodity { get; set; }
        [Required]
        public string Season { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Block { get; set; }
        [Required]
        public string CurrentPrices { get; set; }

    }
}