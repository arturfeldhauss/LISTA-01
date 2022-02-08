using System;

namespace Padaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Financias padaria hoptão");
            Console.WriteLine("Quantos pães foram vendidos?");
            string paes = Console.ReadLine();
            Console.WriteLine("Quantas broas foram vendidas?");
            string broas = Console.ReadLine();

            double doublepaes = Convert.ToDouble(paes);
            double doublebroas = Convert.ToDouble(broas);
            double arrecadacao = doublepaes * 0.12 + doublebroas * 1.50;
            Console.WriteLine(arrecadacao);
            double poupanca = arrecadacao * 0.10;
            Console.WriteLine("O valor destinado a poupança foi de {0}", poupanca);
            Console.WriteLine("a padaria arrecadou {0}R$", arrecadacao);
            Console.ReadLine();












        }
    }
}
