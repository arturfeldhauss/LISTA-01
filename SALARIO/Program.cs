using System;

namespace SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa tarde, digite seu salario");
            string salario = Console.ReadLine();

            double doublesalario = Convert.ToInt32(salario);
            double aumento = doublesalario * 1.15;
            Console.WriteLine("Depois do aumento seu salário é {0}", aumento);
            Console.WriteLine("Agora vamos descontar os impostos");
            double desconto = aumento * 0.92;
            Console.WriteLine("Seu salário final é de {0}", desconto);
            Console.ReadLine();







        }
    }
}
