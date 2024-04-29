using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de 5 produtos:");

            double total = 0;

            for (int i = 1; i <= 5; i++)

            Console.Write("Produto " + i + ": ");
            total += Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do pagamento: ");
            double pagamento = Convert.ToDouble(Console.ReadLine());

            double troco = pagamento - total;

            Console.WriteLine("Troco: " + troco);


        }
    }
}
