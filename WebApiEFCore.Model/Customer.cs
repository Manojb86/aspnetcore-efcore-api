using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiEFCore.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name length must be less than 100")]
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public CustomerDetails CustomerDetails { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
