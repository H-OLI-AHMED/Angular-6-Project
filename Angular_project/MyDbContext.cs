using Microsoft.EntityFrameworkCore;

namespace Angular_project
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        { }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Service> Service { get; set; }
    }

}
