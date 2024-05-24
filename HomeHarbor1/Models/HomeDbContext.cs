using Microsoft.EntityFrameworkCore;

namespace HomeHarbor1.Models
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext(DbContextOptions<HomeDbContext> options) : base(options)
        { }

        public virtual DbSet<Registration> Registrations { get; set; }

        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .Property(x => x.Role)
                .HasDefaultValue("User");
        }
    }
}
