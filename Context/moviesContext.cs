using Microsoft.EntityFrameworkCore;
using WebAssignment.Models;

namespace WebAssignment.Context
{
    public class moviesContext : DbContext
    {
        public moviesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<movies> movies { get; set; }
    }
}
