namespace PraticarAcessoDados.Telas.TelaProduto
{
    public static class MenuProduto
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Produto");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar Produto");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Atualizar Produto");
            Console.WriteLine("4 - Excluir Produto");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    ReadProduto.Load();
                    break;
                case 2:
                    CreateProduto.Load();
                    break;
                case 3:
                    UpdateProduto.Load();
                    break;
                case 4:
                    DeleteProduto.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}