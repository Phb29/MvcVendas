using Microsoft.EntityFrameworkCore;

namespace VendasMVC.net.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Departamento> Departamento { get; set; }
    }
}
