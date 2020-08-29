using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string PieType { get; set; }
    }
}