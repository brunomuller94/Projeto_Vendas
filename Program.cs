using System;
using System.Collections.Generic;

namespace Projeto_Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c;
            //Lista de clientes
            List<Cliente> clientes = new List<Cliente>();


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
                        c = new Cliente();
                        Console.WriteLine("---- CADASTRAR CLIENTE ----\n");
                        Console.WriteLine("Digite o nome do cliente:\n");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:\n");
                        c.Cpf = Console.ReadLine();

                        //Verificacao do CPF
                        if (clientes.Count == 0)
                        {
                            clientes.Add(c);
                            Console.WriteLine("Cliente cadastrado com sucesso!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Cliente clienteCadastrado in clientes)
                            {
                                if (clienteCadastrado.Cpf == c.Cpf)
                                {
                                    //Nao permitir o cadastro
                                    encontrado = true;
                                }
                            }
                            if (!encontrado)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente cadastrado com sucesso!"); 
                            }
                            else
                            {
                                Console.WriteLine("CPF ja se encontra cadastrado!"); 
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("---- LISTAR CLIENTE ----\n");
                        //Laco para listar clientes
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
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
