using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date_of_birth { get; set; }

        public long Phone_number { get; set; }

        public string Email_address { get; set; }
        public string Delivery_address { get; set; }
        public string Password { get; set; }
    }
}
