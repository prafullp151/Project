using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.CustomerReviews
{
    public class CreateModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public CreateModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerName");
        ViewData["RestaurantId"] = new SelectList(_context.Restaurant, "RestaurantId", "RestaurantName");
            return Page();
        }

        [BindProperty]
        public CustomerReview CustomerReview { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CustomerReview.Add(CustomerReview);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
