using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;
using PraticarAcessoDados.Telas.TelaCliente;

namespace PraticarAcessoDados.Telas.TelaCategoria
{
    public static class DeleteCategoria
    {
        public static void Load()
        {
            Console.WriteLine("Para deletar uma categoria, informe seu ID:");
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
                var repository = new Repository<Categoria>();
                repository.Delete(id);
                Console.Clear();
                Console.WriteLine("Categoria deletada com sucesso!");
                Console.ReadKey();
                MenuCategoria.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível deletar a Categoria.");
                Console.ReadKey();
                MenuCategoria.Load();
            }
        }

    }
}