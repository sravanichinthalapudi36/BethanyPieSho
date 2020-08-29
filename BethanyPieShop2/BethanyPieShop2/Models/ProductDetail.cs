using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [Required]
        public double Price { get; set; }


        public string ImagePath { get; set; }
        public Category Catagory { get; set; }
        public int CatagoryId { get; set; }
    }
}