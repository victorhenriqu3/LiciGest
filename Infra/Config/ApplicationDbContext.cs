using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Config;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public ApplicationDbContext() { } // 🔹 Construtor vazio para 'dotnet ef'

    public DbSet<Edital> Editais { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Definir CPF como chave primária no Identity
        modelBuilder.Entity<ApplicationUser>().HasKey(u => u.CPF);

        modelBuilder.Entity<ApplicationUser>().Property(u => u.CPF).HasMaxLength(11).IsRequired();
    }

    // Configuração necessária para SQLite quando usado pelo 'dotnet ef'
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=Data/database.sqlite;");
        }
    }
}
