using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public string Nome { get; set; }
        private int _numConta;
        private int _saldo;
        public int NumConta
        {
            get
            {
                return _numConta;
            }
            set
            {
                if (value > 0)
                {
                    _numConta = value;
                }
            }
        }
        public int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public Conta(string nomeTitular, int numeroConta, int saldoConta)
        {
            Nome = nomeTitular;
            NumConta = numeroConta;
            Saldo = saldoConta;
        }
        public static bool Cadastro(int numeroConta, string nomeTitular)
        {
            if (numeroConta > 0 && nomeTitular != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AlterarNome(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
            {
                Nome = nome;
                Console.WriteLine("Nome alterado com sucesso!");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("O novo nome não pode ser nulo.");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
        }
        public void Deposito(int dep)
        {
            if (dep > 0)
            {
                Saldo = Saldo + dep;
                Console.WriteLine("Depósito realizado com sucesso!");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("O valor de depósito não pode ser nulo.");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
        }
        public bool SaldoDisponivel()
        {
            if (Saldo == 0)
            {
                return false;
            }
            return true;
        }
        public void Saque(int saque)
        {
            if (saque > 0)
            {
                Saldo -= (saque + 5);
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("O valor de saque não pode ser nulo.");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("");
            }
        }
    }
}
