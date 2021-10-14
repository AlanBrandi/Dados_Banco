using System;
using System.Collections.Generic;
using System.Text;

namespace classe_subclasse
{
    //Criação da subclasse, que recebe heranças de Conta.
    class ContaJuridica : Conta
    {
        //Criação da variável EmprestimoLimite junto de encapsulamento.
        public double EmprestimoLimite { get; set; }
        //Criação do construtor padrão.
        public ContaJuridica()
        {
        }
         //Criação do construtor personalizado.
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }
        //Criação do método Emprestimo.
        public void Emprestimo (double saldoTotal)
        {
            //Criação condição.
            if(saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
