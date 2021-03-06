using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplianceReportGenerator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComplianceReportGenerator.Data
{
    public class ReportDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test2> Tests2 { get; set; }
        public DbSet<Test3> Tests3 { get; set; }
        public ReportDbContext(DbContextOptions<ReportDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
