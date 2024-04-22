using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double media;

            Console.Write("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            media = Math.Sqrt(v1 * v2);

            Console.WriteLine("O valor da média geométrica é: ");
            Console.WriteLine(media);

        }
    }
}
