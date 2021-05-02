using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class ShoppingCart
    {
        public List<CartProduct> Items { get; set; } = new List<CartProduct>();

        public decimal ShippingPrice { get; set; }

        public decimal CouponDiscount { get; set; }
    }
}
