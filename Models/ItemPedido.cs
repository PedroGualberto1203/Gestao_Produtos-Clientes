using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Models
{
    [Table("[ItemPedido]")]
    public class ItemPedido
    {

        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}