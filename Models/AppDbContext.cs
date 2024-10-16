using Microsoft.EntityFrameworkCore;

namespace prueba_tecnica_net.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EsettData> EsettDatas { get; set; } 
    }
}
