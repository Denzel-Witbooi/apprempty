using Microsoft.EntityFrameworkCore;
using poe.Models;

namespace poe.Data
{
    public class ApprDbContext : DbContext
    {
        public ApprDbContext(DbContextOptions<ApprDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
