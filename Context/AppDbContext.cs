using apifun.Models;
using Microsoft.EntityFrameworkCore;

namespace apifun.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base (options)
    {
    }

    public DbSet<Setor> Setors {get; set;}

    public DbSet<Funcionario> Funcionarios {get; set;}

}
