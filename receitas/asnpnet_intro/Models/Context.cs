using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace asnpnet_intro.Models
{
    public class Tcontext : DbContext
{
    public Tcontext(DbContextOptions<Tcontext> options) : base(options)
    {}
    public DbSet<Categoria> Categorias {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CursoMVC");
        }
    
}


}