using BethanyPieShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.ViewModel
{
    public class ProDetailsAndCatagory
    {
        public IEnumerable<Category> Catagories { get; set; }
        public ProductDetail ProductDetail { get; set; }
       
    }
}