﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;
            string aux;

            Console.Write("Digite a base do retângulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            a = int.Parse(Console.ReadLine());

            area = a * b;

            Console.Write("A área do retângulo é: ");
            Console.WriteLine(area);

        }
    }
}
