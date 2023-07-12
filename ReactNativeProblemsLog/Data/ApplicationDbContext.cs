using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactNativeProblemsLog.Models;

namespace ReactNativeProblemsLog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ReactNativeProblemsLog.Models.Problem> Problem { get; set; } = default!;
    }
}