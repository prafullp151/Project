using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestReviewSystem.Models
{
    public class CustomerReview
    {
        public int CustomerReviewId { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public string Review { get; set; }
        public int? Rating { get; set; }

    }
}
