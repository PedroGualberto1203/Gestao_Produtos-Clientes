using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class ReadCliente
    {
        public static void Load()
        {
            Console.WriteLine("Lista de Clientes/Usuários:");
            Console.WriteLine("<---------------------------------------------------------->");

            List();

            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Cliente>();
            var clientes = repository.Get();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"\n -Nome: {cliente.Nome}\n -Email: {cliente.Email}\n -Telefone: {cliente.Telefone}\n -CPF: {cliente.CPF}.\n");
                Console.WriteLine("<---------------------------------------------------------->");
            }

            Console.ReadKey();
            MenuCliente.Load();
        }

    }
}