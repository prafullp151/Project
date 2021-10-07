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
    public class DeleteModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public DeleteModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ReviewCategory ReviewCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReviewCategory = await _context.ReviewCategory.FirstOrDefaultAsync(m => m.ReviewCategoryId == id);

            if (ReviewCategory == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReviewCategory = await _context.ReviewCategory.FindAsync(id);

            if (ReviewCategory != null)
            {
                _context.ReviewCategory.Remove(ReviewCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
