using Microsoft.EntityFrameworkCore;

namespace poe.Data
{
    public class ApprDbContext : DbContext
    {
        public ApprDbContext(DbContextOptions<ApprDbContext> options) : base(options)
        {

        }
    }
}
