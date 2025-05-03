using BusinessManager.Interfaces;
using BusinessManager.Services;
using System;

namespace Estudando
{
    class Program
    {
        static void MostrarMenu()
        {
            Console.WriteLine("=== Business Manager ===");
            Console.WriteLine("1. Adicionar Funcionário");
            Console.WriteLine("2. Listar Funcionários");
            Console.WriteLine("3. Remover Funcionários");
            Console.WriteLine("4. Procurar Funcionário");
            Console.WriteLine("5. Pagar Salário");
            Console.WriteLine("0. Sair");
            Console.Write("\nEscolha uma opção: ");
        }

        static void ObterOpcaoMenu()
        {
            int opcao = -1;
            bool entradaValida = false;

            while (!entradaValida)
            {
                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    MostrarMenu();
                }
            }

            return opcao;
        }


        static void Main(string[] args)
        {
            bool executando = true;

            IFuncionarioService funcionarioService = new FuncionarioService();

            while (executando)
            {
                // Mostrar opções
                MostrarMenu();

                // Validar se a entrada é um número válido
                int opcao = ObterOpcaoMenu();

                switch (opcao)
                {
                    case 0:
                        executando = false;
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        funcionarioService.AdicionarFuncionario();
                        break;

                    case 2:
                        funcionarioService.ListarFuncionario();
                        break;

                    case 3:
                        funcionarioService.RemoverFuncionario();
                        break;

                    case 4:
                        funcionarioService.ExibirInformacoes();
                        break;

                    case 5:
                        funcionarioService.PagarFuncionario();
                        break;

                }
            }
        }
    }
}
