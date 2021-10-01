using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestReviewSystem.Models
{
    public class CustomerReview
    {
        public int CustomerReviewId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public string Review { get; set; }
        public int? Rating { get; set; }
        
    }
}
