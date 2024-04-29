using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores quaisquer 'X' e 'Y'.");

            Console.Write("Digite o valor de 'X': ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de 'Y': ");
            double y = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(x, y);

            Console.WriteLine("O resultado de " + x.ToString() + " elevado a " + y.ToString() + " é: " + resultado.ToString());
        }
    }
}
