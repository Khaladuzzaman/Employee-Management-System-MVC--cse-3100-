using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementsystem.Data;
using EmployeeManagementsystem.Models;

namespace EmployeeManagementsystem.Views.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeManagementsystem.Data.EmployeeManagementsystemContext _context;

        public DetailsModel(EmployeeManagementsystem.Data.EmployeeManagementsystemContext context)
        {
            _context = context;
        }

      public Position Position { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Position == null)
            {
                return NotFound();
            }

            var position = await _context.Position.FirstOrDefaultAsync(m => m.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }
            else 
            {
                Position = position;
            }
            return Page();
        }
    }
}
