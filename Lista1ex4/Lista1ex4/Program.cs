using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite a base do triângulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            a = int.Parse(Console.ReadLine());

            area = (a * b) / 2;

            Console.Write("A área do triângulo é: ");
            Console.WriteLine(area);
        }
    }
}
