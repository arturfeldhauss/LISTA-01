using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a imobiliaria imobiliis");
            Console.WriteLine("Digite a Altura do Retangulo");
            string alturamr = Console.ReadLine();
            Console.WriteLine("Digite a Base do Retangulo");
            string basemr = Console.ReadLine();
            int stralturamr = System.Convert.ToInt32(alturamr);
            int strbasemr = System.Convert.ToInt32(basemr);
            int areadoret = stralturamr * strbasemr;
            Console.WriteLine("A area do retangulo é {0} ", areadoret);
            Console.ReadLine();






















        }
    }
}

