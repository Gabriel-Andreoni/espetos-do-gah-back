using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class LevantamentoContext : DbContext
{
    public DbSet<LevantamentoModel> Levantamento { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "Data Source=Levantamento.db");
        base.OnConfiguring(optionsBuilder);
    }
}