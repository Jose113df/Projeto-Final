
using EscolaDotNet.EntityConfigs;
using EscolaDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaDotNet.Contexts;

public class AppDbContext : DbContext
{

    public DbSet<Curso> Cursos => Set<Curso>(); // representa a tabela

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {

        builder.UseSqlServer("Server=DESKTOP-C55KHCV\\SQLEXPRESS;Database=EscolaDotNEt;Integrated Security=True;TrustServerCertificate=True;");

    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder .ApplyConfiguration(new CursoEntityConfig());
    }


}