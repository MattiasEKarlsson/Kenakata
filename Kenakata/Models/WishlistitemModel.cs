using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class WishlistitemModel
    {
        public List<singlewishlistItem> Items { get; set; } = new List<singlewishlistItem>();

    }
    public class singlewishlistItem
    {
        public int Id { get; set; }
    }
}
