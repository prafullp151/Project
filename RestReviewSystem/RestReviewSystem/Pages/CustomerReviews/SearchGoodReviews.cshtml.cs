using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Data;
using RestReviewSystem.Models;
using System.ComponentModel.DataAnnotations;


namespace RestReviewSystem.Pages.CustomerReviews
{
    public class SearchGoodReviewsModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public SearchGoodReviewsModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public IList<CustomerReview> CustomerReview { get;set; }
        public bool SearchCompleted { get; set; }

        public string Query { get; set; }
        public async Task OnGetAsync(string query)
        {
            //Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                var intq = Convert.ToInt16(query);
                CustomerReview = await _context.CustomerReview
                    .Include(c => c.Customer)
                    .Include(c => c.Restaurant)
                    .Where(x => x.Rating.Equals(intq)).ToListAsync();
                   
            }
            else
            {
                SearchCompleted = false;

                CustomerReview = await _context.CustomerReview
                    .Include(c => c.Customer)
                    .Include(c => c.Restaurant).ToListAsync()
                    ;

            }
        }
    }
}
