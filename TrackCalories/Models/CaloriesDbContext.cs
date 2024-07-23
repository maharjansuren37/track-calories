using Microsoft.EntityFrameworkCore;

namespace TrackCalories.Models
{
    public class CaloriesDbContext: DbContext
    {
        public DbSet<Calories> Calories { get; set; }

        public CaloriesDbContext(DbContextOptions<CaloriesDbContext> options) : base(options)
        {
            
        }
    }
}
