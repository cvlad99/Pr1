using Microsoft.EntityFrameworkCore;
using Pr1.Models;

namespace Pr1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
