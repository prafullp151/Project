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

namespace RestReviewSystem.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly RestReviewSystem.Data.RestReviewSystemContext _context;

        public EditModel(RestReviewSystem.Data.RestReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // ADD VALIDATIONS HERE

            //Customer name validation
            var custName = Customer.CustomerName;
            var custId = Customer.CustomerId;
            bool custExistsAlready = _context.Customer.Any(x => x.CustomerName == custName
                                    && x.CustomerId!=custId);
            if (custExistsAlready)
            {
                ModelState.AddModelError("Customer.CustomerName", "Customer Name already exists");
            }
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
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

            _context.Attach(Customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.CustomerId))
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

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
