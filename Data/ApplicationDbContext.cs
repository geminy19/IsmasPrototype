using IsmasPrototype.Models;
using Microsoft.EntityFrameworkCore;

namespace IsmasPrototype.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<WorkList> WorkLists { get; set; }
    }
}
