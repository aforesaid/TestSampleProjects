using Microsoft.EntityFrameworkCore;

namespace TestBulkExtension
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<AModel> AModels { get; protected set; }
    }
}