using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Range(0,5)]
        public int Rating { get; set; }
        //public ReviewCategory ReviewCategory { get; set; }
        //public int ReviewCategoryId { get; set; }

    }
}
