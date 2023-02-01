using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class WalletTransaction 
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public User User { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }    
    }
}
