using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            bool abertura = true;
            Conta conta = null;
            while (abertura)
            {
                Console.WriteLine("Bem vindo ao Banco NGX!\n\nPara criar uma conta, insira o nome do titular:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o número da conta:");
                int numConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do depósito inicial (caso não queira, pressione 0):");
                int depInicial = int.Parse(Console.ReadLine());
                if (Conta.Cadastro(numConta, nome))
                {
                    conta = new Conta(nome, numConta, depInicial);
                    abertura = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valores inválidos inseridos.");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("");
                }
            }
            Console.Clear();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine($"Bem vindo {conta.Nome} à sua conta de número {conta.NumConta}!\nSaldo - {conta.Saldo};\n\n" +
                    $"1 - Alterar nome do titular;\n2 - Depositar valor;\n3 - Sacar valor;\n4 - Sair.\n\nDigite o valor da operação a ser realizada:");
                int inputMenu = int.Parse(Console.ReadLine());
                switch (inputMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Insira o novo nome:");
                        string nomeNovo = Console.ReadLine();
                        Console.Clear();
                        conta.AlterarNome(nomeNovo);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Insira o valor que deseja depositar:");
                        int dep = int.Parse(Console.ReadLine());
                        Console.Clear();
                        conta.Deposito(dep);
                        break;
                    case 3:
                        Console.Clear();
                        if (!conta.SaldoDisponivel())
                        {
                            Console.Clear();
                            Console.WriteLine("Não há saldo disponível para realizar saque.");
                            break;
                        }
                        Console.WriteLine($"Saldo disponível - {conta.Saldo}.\nDigite o valor que deseja sacar:");
                        int saque = int.Parse(Console.ReadLine());
                        Console.Clear();
                        conta.Saque(saque);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar o Banco NGX!");
                        controle = false;
                        break;
                    default:
                        Console.WriteLine("Digito inválido.\n");
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}