using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class UpdateCategoria
    {
        public static void Load()
        {
            Console.WriteLine("Para alterar os dados de uma categoria, informe seu ID:");
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

            Update(new Categoria
            {
                Id = int.Parse(id),
                Nome = nome,
            });
        }

        private static void Update(Categoria categoria)
        {

            try
            {
                var repository = new Repository<Categoria>();
                repository.Update(categoria);
                Console.Clear();
                Console.WriteLine("Categoria atualizada com sucesso!");
                Console.ReadKey();
                MenuCategoria.Load();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Não foi possível atualizar a nova categoria.");
                Console.ReadKey();
                MenuCategoria.Load();
            }
            
        }

    }
}