using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Models
{
    [Table("[Produto]")]
    public class Produto
    {
        public Produto()
        {
            Categoria = new List<Categoria>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        
        [Write(false)] // Isso é para n incluir a Categoria como algo a ser inserido na hora de um create do User por exemplo, se n tiver isso da erro
        public List<Categoria> Categoria { get; set; }
    }
}