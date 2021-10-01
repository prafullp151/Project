using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestReviewSystem.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string DeliveryAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public CustomerReview CustomerReview { get; set; }
        public int CustomerReviewId { get; set; }

    }
}
