using Microsoft.EntityFrameworkCore;

namespace WebshopDolg1Gyak.Modells
{
    public class VasarlasContext : DbContext
    {
        public DbSet<Vasarlo> Vasarlok { get; set; }
        public DbSet<Termekek> Termekek { get; set; }
        public DbSet<Vasarlasok> Vasarlasok { get; set; }

        public readonly string connStr = "server=localhost;userid=root;password=;database=webshopdolgegy";
        public VasarlasContext(DbContextOptions<VasarlasContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
