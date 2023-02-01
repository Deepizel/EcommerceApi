using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Wallet :BaseEntity
    {
        public User User { get; set; }
        public decimal Balance { get; set; }
    }
}
