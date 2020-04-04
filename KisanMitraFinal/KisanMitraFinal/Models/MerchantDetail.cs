using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisanMitraFinal.Models
{
    public class MerchantDetail
    {

        [Display(Name = "MerchantName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name Required")]
        public string MerchantName { get; set; }

        [Key]
        [Display(Name = "MobileNo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number is Required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long MobileNumber { get; set; }

        [Display(Name = "OfficeAddress")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address Required")]
        public string Address { get; set; }

        [Display(Name = "State")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "State Required")]
        public string FState { get; set; }

        [Display(Name = "District")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "District Required")]
        public string District { get; set; }

        [Display(Name = "Block")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Block Required")]
        public string Block { get; set; }

        [Display(Name = "Age")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Age Required")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender Required")]
        public string Gender { get; set; }

        [Display(Name = "UserName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName Required")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum6 Characters required")]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum6 Characters required")]
        [Compare("Password", ErrorMessage = " Confirm  password and password do not match")]
        public string ConfirmPassword { get; set; }
    }
}