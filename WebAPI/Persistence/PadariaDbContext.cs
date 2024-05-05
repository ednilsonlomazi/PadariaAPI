using WebAPI.Entity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace WebAPI.Persistence 
{
    public class PadariaDbContext : DbContext
    {
        public DbSet<TabProduto> TabProdutos {get; set;}
        public DbSet<TabFamilia> TabFamilia {get; set;}
        public PadariaDbContext(DbContextOptions<PadariaDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TabProduto>(e => 
            {
               e.HasKey(tp => tp.Id);

               e.Property(tp => tp.Id).HasColumnName("id");
               
               e.Property(tp => tp.DesProduto).HasColumnName("des_produto")
                .HasMaxLength(256)
                .HasColumnType("varchar(256)");
                
               e.Property(tp => tp.IdFamilia).HasColumnName("id_familia");

               e.Property(tp => tp.IndAtivo).HasColumnName("ind_ativo");
                
            });

            modelBuilder.Entity<TabFamilia>(e => 
            {
               e.HasKey(tp => tp.Id);
               
               e.HasMany(tp => tp.Produtos).WithOne().HasForeignKey(tp => tp.IdFamilia);

               e.Property(tf => tf.Id).HasColumnName("id");

               e.Property(tf => tf.DesFamilia).HasColumnName("des_familia");

               e.Property(tf => tf.IndAtivo).HasColumnName("ind_ativo");
                
            });

            modelBuilder.Entity<TabLogin>(e => 
            {
               e.HasKey(tp => tp.Id);

               e.Property(tp => tp.Id).HasColumnName("id");
               
               e.Property(tp => tp.Username).HasColumnName("username")
                .HasMaxLength(256)
                .HasColumnType("varchar(256)");
                
               e.Property(tp => tp.Password).HasColumnName("password");

               e.Property(tp => tp.IndAtivo).HasColumnName("ind_ativo");

               e.Property(tp => tp.IdPessoa).HasColumnName("id_pessoa");
                
            });
      
            modelBuilder.Entity<TabLogradouro>(e => 
            {
               e.HasKey(tp => tp.Id);

               e.Property(tp => tp.Id).HasColumnName("id");
               
               e.Property(tp => tp.DescLogradouro).HasColumnName("des_logradouro")
                .HasMaxLength(256)
                .HasColumnType("varchar(256)");

               e.Property(tp => tp.IndAtivo).HasColumnName("ind_ativo");

               e.Property(tp => tp.IdPessoa).HasColumnName("id_pessoa");
                
            });

            modelBuilder.Entity<TabPessoa>(e => 
            {
               e.HasKey(tp => tp.Id);
               
               e.HasMany(tp => tp.Login).WithOne().HasForeignKey(tp => tp.IdPessoa);

               e.HasMany(tp => tp.Logradouros).WithOne().HasForeignKey(tp => tp.IdPessoa);

               e.Property(tf => tf.Id).HasColumnName("id");

               e.Property(tf => tf.Nome).HasColumnName("nome");

               e.Property(tf => tf.IndAtivo).HasColumnName("ind_ativo");
                
            });            
                
        }

    }


}