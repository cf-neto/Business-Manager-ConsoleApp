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
            public bool SalarioPago { get; set; }
        }

        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int Produtividade { get; set; }
        public decimal Salario { get; set; }
        public bool SalarioPago { get; set; }

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
            SalarioPago = false;

            Funcionario funcionario = new Funcionario
            {
                Nome = Nome,
                Idade = Idade,
                Cargo = Cargo,
                Salario = Salario,
                Produtividade = Produtividade,
                SalarioPago = SalarioPago
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
                Console.WriteLine($"Salário pago: {funcionario.SalarioPago}");
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
                Console.WriteLine($"Produtividade: {funcionario.Produtividade}");
                Console.WriteLine($"Salário pago: {funcionario.SalarioPago}\n");

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
                funcionarios.Remove(nome);
                Console.WriteLine($"Funcionário: {nome} removido com sucesso!\n");
            }
        }

        public void PagarFuncionario(string nome = null)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Escreva o nome do funcionário: ");
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
                Console.WriteLine($"Produtividade: {funcionario.Produtividade}");
                Console.WriteLine($"Salário pago: {funcionario.SalarioPago}\n");

                Console.WriteLine("\n1. Aumentar Salário");
                Console.WriteLine("2. Diminuir Salário");
                Console.WriteLine("3. Pagar Salário");

                Console.WriteLine("\nEscolha uma das opções acima: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha){
                    case 1:
                        Console.Write("Quanto você quer aumentar do salário? R$");
                        try
                        {
                            decimal aumento = decimal.Parse(Console.ReadLine());
                            funcionario.Salario += aumento;
                            Console.WriteLine($"Salário atualizado: R${funcionario.Salario}");
                        }
                        catch
                        {
                            Console.WriteLine("Erro! Valor inválido.");
                        }
                        break;

                    case 2:
                        Console.Write("Quanto você quer diminuir do salário? R$");
                        try
                        {
                            decimal diminuir = decimal.Parse(Console.ReadLine());
                            funcionario.Salario -= diminuir;
                            Console.WriteLine($"Salário atualizado: R${funcionario.Salario}");
                        }
                        catch
                        {
                            Console.WriteLine("Erro! Valor inválido.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Salário pago!");
                        funcionario.SalarioPago = true;
                        break;
                }

            }
        }

    }
}
