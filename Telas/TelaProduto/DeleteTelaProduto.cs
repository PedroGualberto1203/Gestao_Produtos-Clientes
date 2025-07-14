using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaProduto
{
    public static class DeleteProduto
    {
        public static void Load()
        {
            Console.WriteLine("Para deletar um produto, informe seu ID:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Delete(id);

            Console.ReadKey();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Produto>();
                repository.Delete(id);
                Console.Clear();
                Console.WriteLine("Produto deletado com sucesso!");
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