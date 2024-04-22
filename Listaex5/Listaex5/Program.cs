using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;
            double v4;
            double media;

            Console.Write("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            v3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            v4 = double.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;

            Console.WriteLine("O valor da média aritmética: ");
            Console.WriteLine(media);





        }
    }
}
