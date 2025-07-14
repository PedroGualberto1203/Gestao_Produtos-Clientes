using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaProduto
{
    public static class CreateProduto
    {
        public static void Load()
        {
            Console.WriteLine("Para criar um novo Produto, insira as informações abaixo:");
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

            Console.WriteLine("Id da categoria: ");
            var idCategoria = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Create(new Produto
            {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade,
                CategoriaId = idCategoria
            });

        }

        private static void Create(Produto produto)
        {

            try
            {
                var repository = new Repository<Produto>();
                repository.Create(produto);
                Console.Clear();
                Console.WriteLine("Produto cadastrado com sucesso!");
                Console.ReadKey();
                MenuProduto.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível cadastrar o Produto.");
                Console.ReadKey();
                MenuProduto.Load();
            }

        }
    }
}