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
    public class IndexModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public IndexModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public IList<ReviewCategory> ReviewCategory { get;set; }

        public async Task OnGetAsync()
        {
            ReviewCategory = await _context.ReviewCategory.ToListAsync();
        }
    }
}
