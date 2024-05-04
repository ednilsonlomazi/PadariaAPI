using WebAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Persistence 
{
    public class PadariaDbContext : DbContext
    {
        public DbSet<TabProduto> tabProdutos {get; set;}
        public PadariaDbContext(DbContextOptions<PadariaDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TabProduto>(e => 
            {
               e.HasKey(tp => tp.Id);
               
               e.Property(tp => tp.DesProduto).HasMaxLength(256)
                                              .HasColumnType("varchar(256)")
                                              .HasColumnName("des_produto");

                                           

                
            });
        }

    }


}