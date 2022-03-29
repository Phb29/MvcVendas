namespace VendasMVC.net.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Nascimentodata { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Resgistro { get; set; }=new List<RegistroVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string name, string email, DateTime nascimentodata, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            Nascimentodata = nascimentodata;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void addVendas(RegistroVenda sr)
        {
            Resgistro.Add(sr);
        }
        public void RemoverVendas(RegistroVenda sr)
        {
            Resgistro.Remove(sr);
        }
        public double totalvendas(DateTime inicial,DateTime final)
        {
            return Resgistro.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.montante);
        }
    }
}
