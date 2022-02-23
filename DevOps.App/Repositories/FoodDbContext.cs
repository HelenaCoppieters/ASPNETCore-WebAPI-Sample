using Microsoft.EntityFrameworkCore;
using DevOps.App.Entities;

namespace DevOps.App.Repositories
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options)
           : base(options)
        {

        }

        public DbSet<FoodEntity> FoodItems { get; set; }

    }
}
