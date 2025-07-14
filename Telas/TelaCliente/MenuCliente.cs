namespace PraticarAcessoDados.Telas.TelaCliente
{
    public static class MenuCliente
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Cliente");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar Cliente");
            Console.WriteLine("2 - Cadastrar Cliente");
            Console.WriteLine("3 - Atualizar Cliente");
            Console.WriteLine("4 - Excluir Cliente");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    ReadCliente.Load();
                    break;
                case 2:
                    CreateCliente.Load();
                    break;
                case 3:
                    UpdateCliente.Load();
                    break;
                case 4:
                    DeleteCliente.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}