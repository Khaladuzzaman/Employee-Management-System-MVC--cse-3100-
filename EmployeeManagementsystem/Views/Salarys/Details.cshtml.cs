﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementsystem.Data;
using EmployeeManagementsystem.Models;

namespace EmployeeManagementsystem.Views.Salarys
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeManagementsystem.Data.EmployeeManagementsystemContext _context;

        public DetailsModel(EmployeeManagementsystem.Data.EmployeeManagementsystemContext context)
        {
            _context = context;
        }

      public Salary Salary { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Salary == null)
            {
                return NotFound();
            }

            var salary = await _context.Salary.FirstOrDefaultAsync(m => m.SalaryID == id);
            if (salary == null)
            {
                return NotFound();
            }
            else 
            {
                Salary = salary;
            }
            return Page();
        }
    }
}
