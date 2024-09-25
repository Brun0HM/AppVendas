namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public string NotaFiscal { get; set; }
        public DateTime DataVenda { get; set; }
        public double? TotalVenda { get; set; }
        /* Referencia para a Model Cliente */
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}