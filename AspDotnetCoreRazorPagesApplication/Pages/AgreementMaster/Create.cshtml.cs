using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspDotnetCoreRazorPagesApplication.Data;
using AspDotnetCoreRazorPagesApplication.Models;

namespace AspDotnetCoreRazorPagesApplication.Pages.AgreementMaster
{
    public class CreateModel : PageModel
    {
        private readonly AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext _context;

        public CreateModel(AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Agreement Agreement { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Agreements.Add(Agreement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}