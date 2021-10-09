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
        public IList<CustomerReview> custReviews { get; set; }
        public List<int> AvgRatings = new List<int>();
        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurant.ToListAsync();
            //Calculate the Avarage rating for a restaurant
            if (Restaurant.Count() > 0)
            {
                foreach (var item in Restaurant)
                {
                   custReviews = await _context.CustomerReview
                        .Where(m => m.RestaurantId == item.RestaurantId)
                        .ToListAsync();
                    if (custReviews.Count() > 0)
                    {
                        var AvgRate = (int)custReviews.Average(x => x.Rating);
                        AvgRatings?.Add(AvgRate);
                    }
                    else
                    {
                        AvgRatings?.Add(0);
                    }

                }
            }

        }
    }
}
