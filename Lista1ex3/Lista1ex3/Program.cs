using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;

            Console.Write("Digite o valor da diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());

            area = Math.Pow(diagonal, 2) / 2;

            Console.WriteLine("A área do quadrado é: ");
            Console.WriteLine(area);



        }
    }
}
