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
    public class IndexModel : PageModel
    {
        private readonly AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext _context;

        public IndexModel(AspDotnetCoreRazorPagesApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Agreement> Agreement { get;set; }

        public async Task OnGetAsync()
        {
            Agreement = await _context.Agreements.ToListAsync();
        }
    }
}
