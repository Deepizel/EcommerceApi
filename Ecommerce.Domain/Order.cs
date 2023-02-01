using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Order
    {
        public Products product { get; set; }
        public decimal Total { get; set; }
        public DateTime Order_date { get; set; }
        public string Address { get; set; }
        public int Transaction_id { get; set; }
        public DateTime Delivery_date { get; set; }
        public string Status { get; set; }  
        public int Tracking_number { get; set;}
        public  int Discount { get; set; }
        public int Delivery_fee { get; set; }   
        public Cart Cart { get; set; }
        public User User { get; set; }
    }
}
