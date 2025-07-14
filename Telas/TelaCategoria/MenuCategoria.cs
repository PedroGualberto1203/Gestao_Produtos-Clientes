using PraticarAcessoDados.Telas.TelaCategoria;

namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class MenuCategoria
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categoria");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar Categoria");
            Console.WriteLine("2 - Cadastrar Categoria");
            Console.WriteLine("3 - Atualizar Categoria");
            Console.WriteLine("4 - Excluir Categoria");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    ReadCategoria.Load();
                    break;
                case 2:
                    CreateCategoria.Load();
                    break;
                case 3:
                    UpdateCategoria.Load();
                    break;
                case 4:
                    DeleteCategoria.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}