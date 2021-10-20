using System;

namespace classe_subclasse
{
   abstract class Program
    {
        static void Main(string[] args)
        {
            //Pegando os dados do usuário.
            Console.WriteLine("Envie o seu número da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Envie o seu nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Envie o seu saldo atual: ");
            double Saldo = int.Parse(Console.ReadLine());
            //Criando uma conta Juridica com os dados enviados.
            ContaJuridica conta = new ContaJuridica(Numero , Nome, Saldo, 500.0);
            //Demonstrando o saldo atual.

            Console.WriteLine("Seu saldo atual é de: "+ "R$" + conta.Saldo);
        }
    }
}
