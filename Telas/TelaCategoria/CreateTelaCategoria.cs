using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;
using PraticarAcessoDados.Telas.TelaCliente;

namespace PraticarAcessoDados.Telas.TelaCategoria
{
    public static class CreateCategoria
    {
        public static void Load()
        {
            Console.WriteLine("Para criar uma nova categoria, insira o nome que deseja:");
            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine();

            Create(new Categoria{Nome = nome});

        }

        private static void Create(Categoria categoria)
        {

            try
            {
                var repository = new Repository<Categoria>();
                repository.Create(categoria);
                Console.Clear();
                Console.WriteLine("Categoria cadastrada com sucesso!");
                Console.ReadKey();
                MenuCategoria.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível cadastrar a nova categoria.");
                Console.ReadKey();
                MenuCliente.Load();
            }

        }
    }
}