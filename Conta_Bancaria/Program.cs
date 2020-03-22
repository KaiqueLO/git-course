using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaKaique;

            Console.Write("Informe o numero da conta bancaria: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inical na conta? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaKaique = new Conta(numero, titular, deposito);
            }
            else
            {
                contaKaique = new Conta(numero, titular);
            }

            Console.WriteLine(contaKaique);

            Console.WriteLine("Deseja fazer um deposito");
            char dep = char.Parse(Console.ReadLine());

            if(dep == 's' || dep == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaKaique.Deposito(quantia);
            }

            Console.WriteLine(contaKaique);

            Console.WriteLine("Deseja fazer um saque");
            char valor = char.Parse(Console.ReadLine());

            if(valor == 's' || valor == 'S')
            {
                Console.WriteLine("Entre com o valor do saque");
                double quantiasaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaKaique.Deposito(quantiasaque);
            } 

            Console.WriteLine(contaKaique);
          
        }
    }
}
