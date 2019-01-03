using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Salario
    {
        static void Main(string[] args)
        {
 

            string nome;
            double salarioFixo, totalVendas, TOTAL;

            nome = (Console.ReadLine());
            salarioFixo = double.Parse(Console.ReadLine());
            totalVendas = double.Parse(Console.ReadLine());

            TOTAL = (salarioFixo + ((totalVendas * 15) / 100));

            Console.WriteLine("TOTAL = " + TOTAL.ToString("F2"));
            Console.ReadLine();

        }

    }
}
