#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Models;

namespace W21_Assignment.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly DBContext _context;

        public IndexModel(DBContext context)
        {
            _context = context;
        }

        public IList<W21_Assignment.Models.Menu> Menu { get; set; }

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}
