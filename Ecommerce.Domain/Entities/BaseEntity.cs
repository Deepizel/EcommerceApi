using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime DeletedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
