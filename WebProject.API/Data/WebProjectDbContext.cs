using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebProject.API.Data
{
    /// <summary>
    /// DbContext
    /// </summary>
    public class WebProjectDbContext : DbContext
    {
        /// <summary>
        /// Config
        /// </summary>
        /// <value></value>
        private IConfiguration Configuration { get; init; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public WebProjectDbContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

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