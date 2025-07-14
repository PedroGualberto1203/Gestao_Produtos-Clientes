using Dapper;
using PraticarAcessoDados.Models;

namespace PraticarAcessoDados.Repository
{
    public class ProdutoRepository : Repository<Produto> //Cria o repositório especifico tendo o repository generico(que tem o CRUD) como herança, assim terá todos os métodos lá feitos também
    {//Passamos <Produto> pois vamos criar um Repository especifico de Produto, para podermos trabalhar com a lista de Categoria contida nele

        public List<Produto> GetWithCategoria()
        {
            var query = @"
            SELECT 
                Produto.*,
                Categoria.*
            FROM 
                Produto
                LEFT JOIN Categoria ON Produto.CategoriaId = Categoria.Id;
            "; // Comando SQL do JOIN que junta o tudo de produto e tudo de categoria

            var produtos = new List<Produto>(); // A lista de produtos que vamos retornar com o JOIN

            var items = Database.Connection.Query<Produto, Categoria, Produto>(//Vai receber um Produto e uma Categoria, e eles ficaram guardados dentro de um Produto(esse terceiro da linha), basicamente o JOIN
                query,
                (produto, categoria) =>
                {
                    var prod = produtos.FirstOrDefault(x => x.Id == produto.Id);
                    if (prod == null)
                    {
                        prod = produto;
                        if (categoria != null)
                        {
                            prod.Categoria.Add(categoria);
                        }
                        produtos.Add(prod);
                    }
                    else
                    {
                        prod.Categoria.Add(categoria);
                    }
                    return produto;
                }, splitOn: "Id");
            return produtos;

        }

    }
}