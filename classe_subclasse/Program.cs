using System;
using System.Collections.Generic;
using System.Globalization;

namespace classe_subclasse
{
      class Program
     {
        static void Main(string[] args)
        {
            //Criação da lista de contas.
            List<Conta> list = new List<Conta>();
            list.Add(new ContaPoupanca(1001,"Terry",500.0,0.01));
            list.Add(new ContaJuridica(1002,"Andy",500.0,400));
            list.Add(new ContaPoupanca(1003,"Joe",500.0,0.01));
            list.Add(new ContaJuridica(1001,"Mae",500.0,400));
            //soma dos saldos + variável+ apresentação.
            double Soma = 0.0;
            foreach(Conta acc in list)
            {
                Soma += acc.Saldo;
            }
            Console.WriteLine("Total do saldo de todas as contas: " + Soma.ToString("F2", CultureInfo.InvariantCulture));
           //Taixa retirada das contas.
            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }
            //Demonstração das contas atualizadas.
            foreach(Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas: " + acc.Numero + ":" + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                
            }
        }
     }
}
