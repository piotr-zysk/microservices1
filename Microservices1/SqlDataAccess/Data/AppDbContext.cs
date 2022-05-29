using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Entities;

namespace SqlDataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }

        public DbSet<TaskItemEntity> TaskItems { get; set; }
    }
}
