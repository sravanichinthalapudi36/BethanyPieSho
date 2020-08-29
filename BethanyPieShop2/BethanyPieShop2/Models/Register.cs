using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "FName is required")]
        [StringLength(20, ErrorMessage = "Minimum 3 and Maximum 20 characters required", MinimumLength = 3)]
        public string FName { get; set; }



        [Required(ErrorMessage = "LName is required")]
        [StringLength(20, ErrorMessage = "Minimum 3 and Maximum 20 characters required", MinimumLength = 3)]
        public string LName { get; set; }



        [Required(ErrorMessage = "PhoneNo is required")]
        [RegularExpression(@"\+91[0-9]{10}", ErrorMessage = "Invalid Number")]
        public string PhoneNo { get; set; }




        [Required(ErrorMessage = "EmailId is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }



        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}