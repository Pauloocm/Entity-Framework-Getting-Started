using Microsoft.EntityFrameworkCore;

namespace EfGetStarted.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("BlogDataBase"));
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
