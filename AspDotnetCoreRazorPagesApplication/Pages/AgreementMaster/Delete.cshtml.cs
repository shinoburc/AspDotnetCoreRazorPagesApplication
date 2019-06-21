using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspDotnetCoreRazorPagesApplication.Data;
using AspDotnetCoreRazorPagesApplication.Models;

namespace AspDotnetCoreRazorPagesApplication.Pages.AgreementMaster
{
    public class DeleteModel : PageModel
    {
        private readonly AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext _context;

        public DeleteModel(AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agreement = await _context.Agreements.FindAsync(id);

            if (Agreement != null)
            {
                _context.Agreements.Remove(Agreement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
