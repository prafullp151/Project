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
    public class IndexModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public IndexModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }
        public int AvgRatings { get; set; }
        public async Task OnGetAsync(int? id)
        {
            Restaurant = await _context.Restaurant.ToListAsync();
            //AvgRatings = (int)await _context.CustomerReview.AverageAsync(x => x.Rating);
            //Calculate the Avarage rating for a restaurant
            var custReviews = await _context.CustomerReview
                .Where(m => m.RestaurantId == id)
                .ToListAsync();
            if (custReviews.Count() > 0)
            {
                AvgRatings = (int)await _context.CustomerReview
                            .Where(m => m.RestaurantId == id)
                            .AverageAsync(m => m.Rating);
            }
        }
    }
}
