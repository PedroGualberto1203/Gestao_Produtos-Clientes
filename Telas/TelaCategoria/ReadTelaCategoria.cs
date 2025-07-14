using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;
using PraticarAcessoDados.Telas.TelaCliente;

namespace PraticarAcessoDados.Telas.TelaCategoria
{
    public static class ReadCategoria
    {
        public static void Load()
        {
            Console.WriteLine("Lista de Categorias:");
            Console.WriteLine("<---------------------------------------------------------->");

            List();

            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Categoria>();
            var categorias = repository.Get();
            Console.WriteLine();

            foreach (var categoria in categorias)
            {
                Console.WriteLine($" - {categoria.Nome}");
            }

            Console.ReadKey();
            MenuCategoria.Load();
        }

    }
}