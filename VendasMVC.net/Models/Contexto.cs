using Microsoft.EntityFrameworkCore;

namespace VendasMVC.net.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<RegistroVenda> RegistroVenda { get; set; }
       
        public DbSet<Vendedor> Vendedor { get; set; }

    }
}
