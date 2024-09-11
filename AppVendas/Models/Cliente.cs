namespace AppVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool CadastroAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
