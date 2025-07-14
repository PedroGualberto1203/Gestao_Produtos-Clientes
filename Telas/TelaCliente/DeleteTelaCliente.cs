using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class DeleteCliente
    {
        public static void Load()
        {
            Console.WriteLine("Para deletar um cliente, informe seu ID:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine();

            Delete(int.Parse(id));

            Console.ReadKey();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Cliente>();
                repository.Delete(id);
                Console.Clear();
                Console.WriteLine("Cliente deletado com sucesso!");
                Console.ReadKey();
                MenuCliente.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível cadastrar o cliente.");
                Console.ReadKey();
                MenuCliente.Load();
            }
        }

    }
}