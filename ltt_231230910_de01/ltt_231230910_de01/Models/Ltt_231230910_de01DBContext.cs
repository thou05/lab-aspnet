using Microsoft.EntityFrameworkCore;

namespace ltt_231230910_de01.Models
{
    public class Ltt_231230910_de01DBContext : DbContext
    {
        public Ltt_231230910_de01DBContext(DbContextOptions<Ltt_231230910_de01DBContext> options): base(options)
        {
        }
        public DbSet<LttComputer> LttComputers { get; set; }

    }
}
