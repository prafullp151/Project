using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public DetailsModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }
        public int AvgRatings { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurant.FirstOrDefaultAsync(m => m.RestaurantId == id);
            var custReviews = await _context.CustomerReview
                .Where(m => m.RestaurantId == id)
                .ToListAsync();
            if (custReviews.Count() > 0)
            {
                AvgRatings = (int)await _context.CustomerReview
                            .Where(m => m.RestaurantId == id)
                            .AverageAsync(m => m.Rating);
            }
            
           // AvgRatings = custReviews.Average();
           //     .AverageAsync(x=>x.Rating);
            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
