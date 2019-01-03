using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double comprimento;
            double precoMquadrado;
            double area;
            double precoTotal;



            largura = Double.Parse(Console.ReadLine());
            comprimento = Double.Parse(Console.ReadLine());
            precoMquadrado = Double.Parse(Console.ReadLine());

            area = (comprimento * largura);
            precoTotal = (area * precoMquadrado);


            Console.WriteLine("A Area é de : " + area + "!!");
            Console.WriteLine("O Preco Total é de : " + precoTotal + "!!");
            Console.ReadLine();
            
        }
    }
}
