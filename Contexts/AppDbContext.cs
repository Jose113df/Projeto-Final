
using EscolaDotNet.EntityConfigs;
using EscolaDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaDotNet.Contexts;

public class AppDbContext : DbContext
{

    public DbSet<Curso> Cursos => Set<Curso>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {

        builder.UseSqlServer("Server=DESKTOP-C55KHCVSQLEXPRESS;Database=EscolaDotNEt; Trusted_Connection=True");

    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder .ApplyConfiguration(new CursoEntityConfig());
    }


}