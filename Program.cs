﻿using BusinessManager.Interfaces;
using BusinessManager.Services;
using System;

namespace Estudando
{
    class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;

            IFuncionarioService funcionarioService = new FuncionarioService();

            while (executando)
            {
                Console.WriteLine("=== Business Manager ===");
                Console.WriteLine("1. Adicionar Funcionário");
                Console.WriteLine("2. Listar Funcionários");
                Console.WriteLine("3. Remover Funcionários");
                Console.WriteLine("4. Procurar Funcionário");
                // Console.WriteLine("5. Pagar Salário");   Próxima feature ( deixar esse sistema completo)
                // Console.WriteLine("6. Relatório"); 
                Console.WriteLine("0. Sair");
                Console.Write("\nEscolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

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

                }
            }
        }
    }
}
