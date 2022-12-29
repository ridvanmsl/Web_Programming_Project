using Microsoft.EntityFrameworkCore;
using WebAssignment.Models;

namespace WebAssignment.Context
{
    public class newsContext : DbContext
    {
        public newsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<news> news { get; set; }
    }
}
