using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;
using PraticarAcessoDados.Telas.TelaCliente;

namespace PraticarAcessoDados.Telas.TelaProduto
{
    public static class ReadProduto
    {
        public static void Load()
        {
            Console.WriteLine("Lista de Produtos:");
            Console.WriteLine("<---------------------------------------------------------->");

            List();

            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new ProdutoRepository(); // Como ja foi passado o tipo Produto la no repository, n tem que passar aqui
            var produtos = repository.GetWithCategoria();
            Console.WriteLine();

            foreach (var produto in produtos)
            {
                Console.WriteLine($"\n -Nome: {produto.Nome}\n -Preço: {produto.Preco}\n -Quantidade: {produto.Quantidade}");
                foreach (var categoria in produto.Categoria)
                {
                    Console.WriteLine($" -Categoria: {categoria.Nome}\n");
                    Console.WriteLine("<---------------------------------------------------------->");
                }
            }

            Console.ReadKey();
            MenuProduto.Load();
        }

    }
}