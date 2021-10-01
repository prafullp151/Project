using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestReviewSystem.Models
{
    public class Customer
    {
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        [DisplayName("Customer Address")]
        public string Address { get; set; }
        [DisplayName("Delivery Address")]
        public string DeliveryAddress { get; set; }
        [DisplayName("Phone Number")]
        [Phone]
        public string ContactNumber { get; set; }
        [DisplayName("Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
