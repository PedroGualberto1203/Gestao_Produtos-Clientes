using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class UpdateCliente
    {
        public static void Load()
        {
            Console.WriteLine("Para alterar os dados de um cliente, informe seu ID:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Agora, irforme os dados a serem substituidos/atualizados:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Telefone: ");
            var telefone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("CPF: ");
            var cpf = Console.ReadLine();
            Console.WriteLine();

            Update(new Cliente
            {
                Id = int.Parse(id),
                Nome = nome,
                Email = email,
                Telefone = telefone,
                CPF = cpf
            });
        }

        private static void Update(Cliente cliente)
        {

            try
            {
                var repository = new Repository<Cliente>();
                repository.Update(cliente);
                Console.Clear();
                Console.WriteLine("Cliente atualizado com sucesso!");
                Console.ReadKey();
                MenuCliente.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível atualizar os dados do cliente.");
                Console.ReadKey();
                MenuCliente.Load();
            }
            
        }

    }
}