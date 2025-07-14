using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class CreateCliente
    {
        public static void Load()
        {
            Console.WriteLine("Para criar um novo cliente, insira as informações abaixo:");
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

            Create(new Cliente
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
                CPF = cpf
            });

        }

        private static void Create(Cliente cliente)
        {

            try
            {
                var repository = new Repository<Cliente>();
                repository.Create(cliente);
                Console.Clear();
                Console.WriteLine("Cliente cadastrado com sucesso!");
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