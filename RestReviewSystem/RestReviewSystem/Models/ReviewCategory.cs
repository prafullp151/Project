using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RestReviewSystem.Models
{
    public class ReviewCategory
    {
        public int CustomerReviewId { get; set; }
        public int ReviewCategoryId { get; set; }
        [DisplayName("Food Quality")]
        [Range(0, 5)]
        public int FoodQuality { get; set; }
        [Range(0, 5)]
        public int Service { get; set; }
        [Range(0, 5)]
        public int Cleanliness { get; set; }
        public CustomerReview CustomerReview { get; set; }
    }
}
