using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestReviewSystem.Data;
using RestReviewSystem.Models;

namespace RestReviewSystem.Pages.Customers
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
        public Customer Customer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // ADD VALIDATIONS HERE
            //Customer name validation
            var custName = Customer.CustomerName;
            bool custExistsAlready = _context.Customer.Any(x => x.CustomerName == custName);
            if (custExistsAlready)
            {
                ModelState.AddModelError("Customer.CustomerName", "Customer Name already exists");
            }

            //Customer contact validation
            var custPhone = Customer.ContactNumber;
            bool custPhoneNonUSA = _context.Customer.Any(x => x.ContactNumber.StartsWith('1'));
            if (custPhoneNonUSA)
            {
                ModelState.AddModelError("Customer.ContactNumber", "Customer must be in USA");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
