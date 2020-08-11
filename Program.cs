using System;

namespace Projeto_Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("---- APLICAÇÃO DE VENDAS ----");
                Console.WriteLine("\nSelecione a opcao desejada:");
                Console.WriteLine("\n1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar cliente");
                Console.WriteLine("0 - Sair\n");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("---- CADASTRAR CLIENTE ----\n");
                        break;

                    case 2:
                        Console.WriteLine("---- LISTAR CLIENTE ----\n");
                        break;

                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;

                    default:
                        Console.WriteLine("---- OPCAO INVALIDA ----");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        } 
    }
}
