using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Models
{
    [Table("[Cliente]")]
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
    }
}