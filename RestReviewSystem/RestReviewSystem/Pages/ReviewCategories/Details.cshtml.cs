using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.ReviewCategories
{
    public class DetailsModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public DetailsModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public ReviewCategory ReviewCategory { get; set; }
        public CustomerReview CustomerReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReviewCategory = await _context.ReviewCategory.FirstOrDefaultAsync(m => m.ReviewCategoryId == id);
            var CustRevId = ReviewCategory.CustomerReviewId;
            CustomerReview = _context.CustomerReview.FirstOrDefault(x=>x.CustomerReviewId==CustRevId);
            if (ReviewCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
