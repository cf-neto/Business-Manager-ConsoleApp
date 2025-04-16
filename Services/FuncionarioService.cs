using BusinessManager.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessManager.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        public readonly Dictionary<string, Funcionario> funcionarios = new Dictionary<string, Funcionario>();

        public class Funcionario
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Cargo { get; set; }
            public int Produtividade { get; set; }
            public decimal Salario { get; set; }
        }

        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int Produtividade { get; set; }
        public decimal Salario { get; set; }

        public void AdicionarFuncionario()
        {
            // PEGAR INFORMAÇÕES
            Console.Write("\nNome do funcionário: ");
            Nome = Console.ReadLine();
            Console.Write("\nIdade do funcionário: ");
            Idade = int.Parse(Console.ReadLine());
            Console.Write($"\nQual cargo de {Nome}? ");
            Cargo = Console.ReadLine();
            Console.Write($"\nQual Salário de {Nome}? ");
            Salario = decimal.Parse(Console.ReadLine());
            Produtividade = 0;

            Funcionario funcionario = new Funcionario
            {
                Nome = Nome,
                Idade = Idade,
                Cargo = Cargo,
                Salario = Salario,
                Produtividade = Produtividade
            };

            funcionarios[Nome] = funcionario;

            Console.WriteLine("\n=-=-= Funcionário adicionado !=-=-=");
        }

        public void ExibirInformacoes(string nome = null)
        {
            Console.Write("Digite o nome do funcionário que deseja procurar: ");
            nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Digite o nome do funcionário que deseja procurar: ");
                nome = Console.ReadLine();
            }
            if (funcionarios.ContainsKey(nome))
            {
                var funcionario = funcionarios[nome];
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Idade: {funcionario.Idade}");
                Console.WriteLine($"Cargo: {funcionario.Cargo}");
                Console.WriteLine($"Salário: {funcionario.Salario:C}");
                Console.WriteLine($"Produtividade: {funcionario.Produtividade}\n");
            }
            else
            {
                Console.WriteLine("\nFuncionário não encontrado.");
            }
            
        }

        public void ListarFuncionario(){
            
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("\nNão existe nenhum funcionário adicionado!\n");
            }

            foreach (var funcionario in funcionarios.Values)
            {

                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Idade: {funcionario.Idade}");
                Console.WriteLine($"Cargo: {funcionario.Cargo}");
                Console.WriteLine($"Salário: {funcionario.Salario:C}");
                Console.WriteLine($"Produtividade: {funcionario.Produtividade}\n");

            }
        }

        public void RemoverFuncionario(string nome = null)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Escreva o nome do funcionário que deseja remover: ");
                nome = Console.ReadLine();
            }
            if (funcionarios.ContainsKey(nome))
            {
                Console.WriteLine($"Funcionário: {nome} removido com sucesso!\n");
            }
        }



    }
}
