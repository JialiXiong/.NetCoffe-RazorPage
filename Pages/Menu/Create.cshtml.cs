#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using W21_Assignment.Models;

namespace W21_Assignment.Pages.Menu
{
    public class CreateModel : PageModel
    {
        private readonly DBContext _context;

        public CreateModel(DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public W21_Assignment.Models.Menu Menu { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Menu.Add(Menu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
