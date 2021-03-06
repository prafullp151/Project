using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.CustomerReviews
{
    public class DetailsModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public DetailsModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public CustomerReview CustomerReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerReview = await _context.CustomerReview
                .Include(c => c.Customer)
                .Include(c => c.Restaurant).FirstOrDefaultAsync(m => m.CustomerReviewId == id);

            if (CustomerReview == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
