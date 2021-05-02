using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class Size
    {
        public Size()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
