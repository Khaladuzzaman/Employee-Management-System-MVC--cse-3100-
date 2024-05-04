﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementsystem.Data;
using EmployeeManagementsystem.Models;

namespace EmployeeManagementsystem.Views.Departments
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeManagementsystem.Data.EmployeeManagementsystemContext _context;

        public IndexModel(EmployeeManagementsystem.Data.EmployeeManagementsystemContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Department != null)
            {
                Department = await _context.Department.ToListAsync();
            }
        }
    }
}
