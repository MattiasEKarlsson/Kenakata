using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class Colour
    {
        public Colour()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string ColourName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
