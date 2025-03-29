using Microsoft.EntityFrameworkCore;
using ChefsBatch.Repository.Models;

namespace ChefsBatch.Repository
{
    public class ChefsBatchContext : DbContext
    {
        public ChefsBatchContext(DbContextOptions<ChefsBatchContext> options)
            : base(options)
        {
        }

        public DbSet<Chef> Chefs { get; set; }
    }
}
