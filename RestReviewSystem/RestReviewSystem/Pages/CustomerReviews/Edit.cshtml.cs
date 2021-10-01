using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.CustomerReviews
{
    public class EditModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public EditModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
           ViewData["RestaurantId"] = new SelectList(_context.Restaurant, "RestaurantId", "RestaurantId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CustomerReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerReviewExists(CustomerReview.CustomerReviewId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerReviewExists(int id)
        {
            return _context.CustomerReview.Any(e => e.CustomerReviewId == id);
        }
    }
}
