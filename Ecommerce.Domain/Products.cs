using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price  { get; set; }
        public decimal Size  { get; set; }

        public string Image { get; set; }

        public string Color { get; set; }

        public int Category_id { get; set; }
        public int Quantity { get; set;}
    }

}
