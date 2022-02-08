using System;

namespace Graus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia, digite a temperatura em graus celcius");
            string celcius = Console.ReadLine();

            double intcelcius = Convert.ToInt32(celcius);
            double far = intcelcius * 1.8 + 32;
            Console.WriteLine("A temperatura em Fahrenheit é {0}", far);
            Console.ReadLine();









        }
    }
}


