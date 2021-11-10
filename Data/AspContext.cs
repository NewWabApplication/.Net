using Microsoft.EntityFrameworkCore;
using Asp.Models;

namespace Asp.Data
{
    public class AspContext : DbContext
    {
        public AspContext (DbContextOptions<AspContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
