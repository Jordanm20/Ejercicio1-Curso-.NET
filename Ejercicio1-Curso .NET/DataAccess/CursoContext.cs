using Microsoft.EntityFrameworkCore;
using Ejercicio1_Curso_.NET.Models.DataModels;

namespace Ejercicio1_Curso_.NET.DataAccess
{
    public class CursoContext:DbContext
    {
       public CursoContext(DbContextOptions<CursoContext> options) : base(options) {
        
        
        }
        public DbSet<Cursos> Cursos { get; set; }

    }
    
}
