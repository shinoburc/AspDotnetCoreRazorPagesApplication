using System;
using System.Collections.Generic;
using System.Text;
using AspDotnetCoreRazorPagesApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspDotnetCoreRazorPagesApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agreement> Agreements { get; set; }
    }
}
