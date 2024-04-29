using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Conversor de Dólares para Reais");

            Console.Write("Digite a cotação do dólar (em Reais): ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            double valorEmReais = cotacaoDolar * quantidadeDolares;

            Console.WriteLine("O valor de " + quantidadeDolares.ToString() + " dólares equivale a R$" + valorEmReais.ToString() + ".");





        }
    }
}
