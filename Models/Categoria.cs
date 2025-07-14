using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Models
{
    [Table("[Categoria]")]
    public class Categoria
    {

        public int Id { get; set; }
        public string Nome { get; set; }

    }
}