using E_commerceFarmacia.Model;
using Microsoft.EntityFrameworkCore;

namespace E_commerceFarmacia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("tb_produtos");
            modelBuilder.Entity<Categoria>().ToTable("tb_categorias");

        }

        public DbSet<Categoria> Produto { get; set; } = null!;
        public DbSet<Categoria> Categoria { get; set; } = null!;

    }
}
