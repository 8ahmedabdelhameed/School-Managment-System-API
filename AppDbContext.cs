using Microsoft.EntityFrameworkCore;
using SchoolManagment.Model;

namespace SchoolManagment
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Laptop> laptops { get; set; }
    }
}
