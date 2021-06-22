using Microsoft.EntityFrameworkCore;

namespace WebProject.API.Data
{
    // Configuration
    // DI

    /// <summary>
    /// DbContext
    /// </summary>
    public class WebProjectDbContext : DbContext
    {
        /// <summary>
        /// OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCoreWebDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}