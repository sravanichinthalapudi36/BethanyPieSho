using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public int NoOfOrder { get; set; }
        public double TotalPrice { get; set; }
        public bool IsDelivered { get; set; }
        public Register Register { get; set; }
        public int UserId { get; set; }
    }
}