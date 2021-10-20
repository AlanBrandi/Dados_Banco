using System;
using System.Collections.Generic;
using System.Text;

namespace classe_subclasse
{
   public abstract class Conta
    {
        //Criação das variáveis, com o encapsulamento.
        public int Numero { get; private set;}
        public string Titular { get; private set;}
        public double Saldo { get; protected set; }
        //Criação do construtor padrão.
        public Conta()
        {
        }
        //Criação do construtor personalizado.
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //Criação dos métodos Saque e Deposito.
        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        public void Deposito (double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}
