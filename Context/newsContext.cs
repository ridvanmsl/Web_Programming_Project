using Microsoft.EntityFrameworkCore;
using WebAssignment.Models;

namespace WebAssignment.Context
{
    public class newsContext : DbContext
    {
        public newsContext(DbContextOptions<newsContext> options) : base(options)
        {
        }

        public DbSet<news> news { get; set; }
    }
}
