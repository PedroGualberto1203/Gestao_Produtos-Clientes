using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Models
{
    [Table("[Pedido]")]
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
    }
}