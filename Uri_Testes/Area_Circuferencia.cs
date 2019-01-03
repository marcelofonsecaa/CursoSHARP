using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Uri_Testes
{
    class Area_Circuferencia
    {
        static void Main(string[] args)
        {
            double raio, area;

            raio = Double.Parse(Console.ReadLine());
            area = 3.14159 * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4"));
            Console.ReadLine();
        }
    }
}
