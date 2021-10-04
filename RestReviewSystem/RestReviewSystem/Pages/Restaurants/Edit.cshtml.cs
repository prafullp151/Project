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

namespace RestReviewSystem.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public EditModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurant.FirstOrDefaultAsync(m => m.RestaurantId == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
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
            // ADD VALIDATIONS HERE
            //Restaurant name validation
            var restName = Restaurant.RestaurantName;
            var currentId = Restaurant.RestaurantId;
            bool restExistsAlready = _context.Restaurant.Any(x => x.RestaurantName == restName
                                    && x.RestaurantId != currentId );
            if (restExistsAlready)
            {
                ModelState.AddModelError("Restaurant.RestaurantName", "Restaurant Name already exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(Restaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(Restaurant.RestaurantId))
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

        private bool RestaurantExists(int id)
        {
            return _context.Restaurant.Any(e => e.RestaurantId == id);
        }
    }
}
