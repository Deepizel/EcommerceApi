using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public Products Product { get; set; }
        public decimal Total { get; set; }

        public  bool Purchased { get; set; }

    }
}
