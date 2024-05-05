﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Persistence;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    [DbContext(typeof(PadariaDbContext))]
    [Migration("20240505134328_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Entity.TabFamilia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DesFamilia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("des_familia");

                    b.Property<bool>("IndAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("ind_ativo");

                    b.HasKey("Id");

                    b.ToTable("TabFamilia");
                });

            modelBuilder.Entity("WebAPI.Entity.TabLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int")
                        .HasColumnName("id_pessoa");

                    b.Property<bool>("IndAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("ind_ativo");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("TabLogin");
                });

            modelBuilder.Entity("WebAPI.Entity.TabLogradouro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescLogradouro")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("des_logradouro");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int")
                        .HasColumnName("id_pessoa");

                    b.Property<bool>("IndAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("ind_ativo");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("TabLogradouro");
                });

            modelBuilder.Entity("WebAPI.Entity.TabPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IndAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("ind_ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("TabPessoa");
                });

            modelBuilder.Entity("WebAPI.Entity.TabProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DesProduto")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("des_produto");

                    b.Property<int>("IdFamilia")
                        .HasColumnType("int")
                        .HasColumnName("id_familia");

                    b.Property<bool>("IndAtivo")
                        .HasColumnType("bit")
                        .HasColumnName("ind_ativo");

                    b.HasKey("Id");

                    b.HasIndex("IdFamilia");

                    b.ToTable("TabProdutos");
                });

            modelBuilder.Entity("WebAPI.Entity.TabLogin", b =>
                {
                    b.HasOne("WebAPI.Entity.TabPessoa", null)
                        .WithMany("Login")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Entity.TabLogradouro", b =>
                {
                    b.HasOne("WebAPI.Entity.TabPessoa", null)
                        .WithMany("Logradouros")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Entity.TabProduto", b =>
                {
                    b.HasOne("WebAPI.Entity.TabFamilia", null)
                        .WithMany("Produtos")
                        .HasForeignKey("IdFamilia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Entity.TabFamilia", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("WebAPI.Entity.TabPessoa", b =>
                {
                    b.Navigation("Login");

                    b.Navigation("Logradouros");
                });
#pragma warning restore 612, 618
        }
    }
}
