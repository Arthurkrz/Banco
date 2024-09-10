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
                if (_saldo == 0)
                {
                    Console.WriteLine("Não há saldo disponível");
                }
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
            }
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
        public Conta(string nomeTitular, int numeroConta, int saldoConta)
        {
            Nome = nomeTitular;
            NumConta = numeroConta;
            Saldo = saldoConta;
        }
    }
}
