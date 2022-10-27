using CommandersNET6.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandersNET6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands => Set<Command>();
    }
}
