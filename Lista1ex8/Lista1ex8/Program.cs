using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Celsius para Fahrenheit");

            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura de " + celsius + " graus Celsius equivale a " + fahrenheit + " graus Fahrenheit.");


        }
    }
}
