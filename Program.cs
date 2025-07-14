using System;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using PraticarAcessoDados.Models;
using PraticarAcessoDados.Repository;
using PraticarAcessoDados.Telas.TelaCliente;
using PraticarAcessoDados.Telas.TelaProduto;

namespace PraticarAcessoDados
{
    class Program
    {

        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=PerfilTreino;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

        static void Main(string[] args)
        {

            Database.Connection = new SqlConnection(CONNECTION_STRING);

            Database.Connection.Open();

            Menu();

            Console.ReadKey();
            Database.Connection.Close();

        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Perfil Acessórios");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de Cliente");
            Console.WriteLine("2 - Gestão de Categoria");
            Console.WriteLine("3 - Gestão de Produto");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuCliente.Load();
                    break;
                case 2:
                    MenuCategoria.Load();
                    break;
                case 3:
                    MenuProduto.Load();
                    break;
                default: Menu(); break;
            }
        }

    }
}