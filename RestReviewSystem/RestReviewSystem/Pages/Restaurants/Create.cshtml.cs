using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.Restaurants
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
            return Page();
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // ADD VALIDATIONS HERE
            //Restaurant name validation
            var restName = Restaurant.RestaurantName;
            bool restExistsAlready = _context.Restaurant.Any(x=>x.RestaurantName==restName);
            if (restExistsAlready)
            {
                ModelState.AddModelError("Restaurant.RestaurantName", "Restaurant Name already exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restaurant.Add(Restaurant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
