using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaProduto
{
    public static class UpdateProduto
    {
        public static void Load()
        {
            Console.WriteLine("Para alterar os dados de um produto, informe seu ID:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Agora, irforme os dados a serem substituidos/atualizados:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Preço: ");
            var preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("ID da categoria: ");
            var idCategoria = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Update(new Produto
            {
                Id = id,
                Nome = nome,
                Quantidade = quantidade,
                Preco = preco,
                CategoriaId = idCategoria
            });
        }

        private static void Update(Produto produto)
        {

            try
            {
                var repository = new Repository<Produto>();
                repository.Update(produto);
                Console.Clear();
                Console.WriteLine("Produto atualizado com sucesso!");
                Console.ReadKey();
                MenuProduto.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível atualizar os dados do Produto.");
                Console.ReadKey();
                MenuProduto.Load();
            }
            
        }

    }
}