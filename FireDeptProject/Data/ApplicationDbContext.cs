using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FireDeptProject.Models;

namespace FireDeptProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FireDeptProject.Models.Case> Case { get; set; } = default!;
        public DbSet<FireDeptProject.Models.Unit> Unit { get; set; } = default!;
        public DbSet<FireDeptProject.Models.Vehicles> Vehicles { get; set; } = default!;
    }
}
