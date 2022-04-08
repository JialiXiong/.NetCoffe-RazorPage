#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Models;

namespace W21_Assignment.Pages.Coffee
{
    public class DeleteModel : PageModel
    {
        private readonly DBContext _context;

        public DeleteModel(DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public W21_Assignment.Models.Coffee Coffee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coffee = await _context.Coffee.FirstOrDefaultAsync(m => m.CoffeeId == id);

            if (Coffee == null)
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

            Coffee = await _context.Coffee.FindAsync(id);

            if (Coffee != null)
            {
                _context.Coffee.Remove(Coffee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
