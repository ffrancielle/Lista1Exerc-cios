using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Milhas Marítimas para Quilômetros");

            double milhasMetros = 1852;
            double quilometrosMetros = 1000;

            Console.Write("Digite a o valor de milhas marítimas: ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            double metros = milhas * milhasMetros;

            double quilometros = metros / quilometrosMetros;

            Console.WriteLine(milhas + " milhas marítimas equivalem a " + quilometros + " quilômetros.");






        }
    }
}
