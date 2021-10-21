using System;
using System.Collections.Generic;
using System.Text;

namespace classe_subclasse
{
    class ContaPoupanca : Conta
    {
        //Definição da variável TaxaJuros.
        public double TaxaJuros { get; set; }
        //Criação do construtor padrão.
        public ContaPoupanca()
        {
        }
        //Criação do construtor personalizado.
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        //Criação do método atualizacaoSaldo.
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //Método + override de Saque.
        
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            //Taxa dada pelo banco.
            Saldo -= 2.0;
        }
    }
}
