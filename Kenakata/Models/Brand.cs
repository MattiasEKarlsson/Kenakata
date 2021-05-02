using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
