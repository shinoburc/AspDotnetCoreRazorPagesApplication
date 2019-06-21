using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspDotnetCoreRazorPagesApplication.Data;
using AspDotnetCoreRazorPagesApplication.Models;

namespace AspDotnetCoreRazorPagesApplication.Pages.AgreementMaster
{
    public class EditModel : PageModel
    {
        private readonly AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext _context;

        public EditModel(AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Agreement Agreement { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agreement = await _context.Agreements.FirstOrDefaultAsync(m => m.Id == id);

            if (Agreement == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Agreement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgreementExists(Agreement.Id))
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

        private bool AgreementExists(int id)
        {
            return _context.Agreements.Any(e => e.Id == id);
        }
    }
}
