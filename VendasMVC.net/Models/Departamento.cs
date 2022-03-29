namespace VendasMVC.net.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; }= new List<Vendedor>();
        
        public Departamento()
        {

        }

        public Departamento(int id, string? name)
        {
            Id = id;
            Name = name;
        }
        public void addvendas(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        public double totalvendedores(DateTime inicial,DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.totalvendas(inicial, final));
        }
    }
   
}
