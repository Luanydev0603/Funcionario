using funcionario.Models;
using Microsoft.EntityFrameworkCore;

namespace apiitens.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base
    (options)
{

}   

    public DbSet<Setor> Setors {get;set;}
    public DbSet<Funcionario> Funcionarios {get;set;}

}