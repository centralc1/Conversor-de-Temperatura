using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, k, f;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.WriteLine("Insira a Temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            // (c * 9 / 5 + 32= F
            f = (c * 9 / 5) + 32;

            // c + 273,15
            k = +273.15;

            Console.WriteLine(c + " Graus Celcius = " + f + " Graus Fahrenheit");
            Console.WriteLine(c + " Graus Celcius = " + k + " Graus Kelvin");
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
    }
}
