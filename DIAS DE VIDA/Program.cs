using System;

namespace DIAS_DE_VIDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia, digite seu nome!!");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite sua idade");
            string idade = Console.ReadLine();
            int numidade = Convert.ToInt32(idade);
            int dias = numidade * 365;
            Console.WriteLine(nome + " voce ja viveu {0} dias!!", dias);
            Console.ReadLine();







        }
    }
}
