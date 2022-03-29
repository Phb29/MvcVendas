namespace VendasMVC.net.Models
{
    public class RegistroVenda
    {
        public  int Id { get; set; }
        public DateTime Data { get; set; }
        public double montante { get; set; }
        public Status Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {

        }

        public RegistroVenda(int id, DateTime data, double montante, Status status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            this.montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
    
}
