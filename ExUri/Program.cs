using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExUri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Calcular preço
            //int codigo_1, numero_1, codigo_2, numero_2;
            //double preco, valor_1, valor_2;

            //codigo_1 = int.Parse(Console.ReadLine());
            //numero_1 = int.Parse(Console.ReadLine());
            //valor_1 = double.Parse(Console.ReadLine());
            //codigo_2 = int.Parse(Console.ReadLine());
            //numero_2 = int.Parse(Console.ReadLine());
            //valor_2 = double.Parse(Console.ReadLine());


            //preco = (numero_1 * valor_1) + (numero_2 * valor_2);

            //Console.WriteLine("VALOR A PAGAR = " + preco.ToString("F2"));
            //Console.ReadLine();
            #endregion

            #region 2 Volume do circulo
            //double VOLUME, raio, pi = 3.14159;

            //raio = double.Parse(Console.ReadLine());

            //VOLUME = (4.0 / 3.0 * pi * raio * raio * raio);

            //Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"));
            //Console.ReadLine();
            #endregion

            #region 3 Area das superficies
            //double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO, pi = 3.14159;

            //string[] valores = Console.ReadLine().Split(' ');

            //A = double.Parse(valores[0]);
            //B = double.Parse(valores[1]);
            //C = double.Parse(valores[2]);

            //TRIANGULO = (A * C / 2);
            //CIRCULO = (C * C * pi);
            //TRAPEZIO = ((A + B) / 2 * C);
            //QUADRADO = (B * B);
            //RETANGULO = (A * B);

            //Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3"));
            //Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
            //Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
            //Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
            //Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));

            //Console.ReadLine();
            #endregion

            #region 4 Ver maior valor
            //double a, b, c, MaiorAB;

            //string[] valores = Console.ReadLine().Split(' ');

            //a = double.Parse(valores[0]);
            //b = double.Parse(valores[1]);
            //c = double.Parse(valores[2]);

            //MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            //MaiorAB = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            //Console.WriteLine(MaiorAB + " eh o maior");
            //Console.ReadKey();

            #endregion

            #region 5 Distancia entre os carros
            //int x;
            //double y, total;


            //x = int.Parse(Console.ReadLine());
            //y = double.Parse(Console.ReadLine());

            //total = (x / y);

            //Console.WriteLine(total.ToString("F3") + " km/l");
            //Console.ReadKey();
            #endregion

            #region 6 Distancia entre 2 pontos
            //double x1, x2, y1, y2, distancia;


            //string[] valores = console.readline().split(' ');
            //string[] valores2 = console.readline().split(' ');


            //x1 = double.parse(valores[0]);
            //y1 = double.parse(valores[1]);

            //x2 = double.parse(valores2[0]);
            //y2 = double.parse(valores2[1]);

            //distancia = math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            //console.writeline(distancia.tostring("f4"));
            //console.readkey();
            #endregion

            #region 7 Tempo para os carros se alcançarem
            //int distancia;
            //int t;

            //distancia = int.Parse(Console.ReadLine());

            //t = Math.Abs(-distancia/(90 - 60)) *60;

            //Console.WriteLine(t + "minutos");
            //Console.ReadKey();
            #endregion

            #region 8 Qts litros foram usados!

            //int tempo, velocidade;
            //double distancia, litros;

            //tempo = int.Parse(Console.ReadLine());
            //velocidade = int.Parse(Console.ReadLine());

            //distancia = tempo * velocidade;
            //litros = distancia / 12;

            //Console.WriteLine(litros.ToString("F3"));
            //Console.ReadKey();
            #endregion

            #region 9 SALARIO + BONUS (HARD)
            //string nome;
            //double salario, vendas, total;

            //nome = Console.ReadLine();
            //salario = double.Parse(Console.ReadLine());
            //vendas = double.Parse(Console.ReadLine());

            //total = (vendas * 0.15) + salario;

            //Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
            //Console.ReadKey();
            #endregion

            #region 10 CEDULAS 

            //int n1, n2, n5, n10, n20, n50, n100;
            //int N;

            //N = int.Parse(Console.ReadLine());
            //if (N > 0 && N < 1000000)
            //{

            //    n100 = N / 100;
            //    N = N % 100;
            //    n50 = N / 50;
            //    N %= 50;
            //    n20 = N / 20;
            //    N %= 20;
            //    n10 = N / 10;
            //    N %= 10;
            //    n5 = N / 5;
            //    N %= 5;
            //    n2 = N / 2;
            //    N %= 2;
            //    n1 = N / 1;
            //    N %= 1;

            //    Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            //    Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            //    Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            //    Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            //    Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            //    Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            //    Console.WriteLine(n1 + " nota(s) de R$ 1,00");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Valor Invalido");
            //    Console.ReadKey();
            //}
            #endregion

            #region 11 Conversao de segundos pra horario.
            //int n, horas, minutos, segundos;

            //n = int.Parse(Console.ReadLine());
            //horas = n / 3600;
            //minutos = (n % 3600) / 60;
            //segundos = (n % 3600) % 60;
            //Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            //Console.ReadKey();
            #endregion

            #region 12 idade em dias

            //int n, ano, mes, dias;

            //n = int.Parse(Console.ReadLine());
            //ano = n / 365;
            //mes = (n % 365) / 30;
            //dias = (n % 365) % 30;

            //Console.WriteLine(ano + " ano(s)");
            //Console.WriteLine(mes + " mes(es)");
            //Console.WriteLine(dias + " dia(s)");
            //Console.ReadKey();

            #endregion

            #region 13 Cedulas e moedas

            //double n1, n2, n5, n10, n20, n50, n100, m1, m50, m25, m10, m5;
            //double N, centavos;

            //N = double.Parse(Console.ReadLine());

            //centavos = N * 100;

            //n100 = N / 100;
            //N = N % 100;
            //n50 = N / 50;
            //N %= 50;
            //n20 = N / 20;
            //N %= 20;
            //n10 = N / 10;
            //N %= 10;
            //n5 = N / 5;
            //N %= 5;
            //n2 = N / 2;
            //N %= 2;
            //n1 = N / 1;
            //N %= 1;

            //centavos = centavos % 100;

            //m50 = centavos / 50;
            //centavos = centavos % 50;
            //m25 = centavos / 25;
            //centavos = centavos % 25;
            //m10 = centavos / 10;
            //centavos = centavos % 10;
            //m5 = centavos / 5;
            //centavos = centavos % 5;
            //m1 = centavos;

            //Console.WriteLine("NOTAS: ");
            //Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            //Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            //Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            //Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            //Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            //Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            //Console.WriteLine("MOEDAS: ");
            //Console.WriteLine(n1 + " Moeda(s) de R$ 1,00");
            //Console.WriteLine(m50 + " Moeda(s) de R$ 0,50");
            //Console.WriteLine(m25 + " Moeda(s) de R$ 0,25");
            //Console.WriteLine(m10 + " Moeda(s) de R$ 0,10");
            //Console.WriteLine(m5 + " Moeda(s) de R$ 0,05");
            //Console.WriteLine(m1 + " Moeda(s) de R$ 0,01");
            //Console.ReadKey();

            #endregion

            #region 14 Teste de Seleçao

            //int A, B, C, D;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());


            //if ((B > C) && (D > A) && (C + D) > (A + B) && (C > 0 && D > 0) && (A % 2 == 0))
            //{
            //    Console.WriteLine("Valores nao aceitos");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Valores aceitos");
            //    Console.ReadKey();
            //}
            #endregion

            #region 15 Bhaskara
            //double A, B, C, R1, R2, delta, raiz;

            //string[] valores = Console.ReadLine().Split(' ');

            //A = double.Parse(valores[0]);
            //B = double.Parse(valores[1]);
            //C = double.Parse(valores[2]);


            //delta = (B * B) - (4 * A * C);
            //raiz = Math.Sqrt(delta);
            //if ((delta > 0) && (A != 0))
            //{
            //    R1 = ((-(B)) + raiz) / (2 * A);
            //    R2 = ((-(B)) - raiz) / (2 * A);

            //    Console.WriteLine("R1 = " + R1.ToString("F5"));
            //    Console.WriteLine("R2 = " + R2.ToString("F5"));
            //}
            //else
            //{
            //    Console.WriteLine("Impossivel Calcular");
            //}
            //Console.ReadKey();
            #endregion

            #region 16 Intervalo

            //double a;

            //a = double.Parse(Console.ReadLine());

            //if (a >= 0 && a <= 25)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (a > 25 && a <= 50)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (a > 50 && a <= 75)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else if (a > 75 && a <= 100)
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");

            //}
            //Console.ReadKey();
            #endregion

            #region 17 Lanchonete
            //int a, b;
            //double total;

            //string[] valores = Console.ReadLine().Split(' ');

            //a = int.Parse(valores[0]);
            //b = int.Parse(valores[1]);

            //switch (a)

            //{
            //    case 1:
            //        total = b * 4.00;
            //       Console.WriteLine("Total: R$ " + total.ToString("F2"));
            //        break;

            //    case 2:
            //        total = b * 4.50;
            //        Console.WriteLine("Total: R$ " + total.ToString("F2"));
            //        break;

            //    case 3:
            //        total = b * 5.00;
            //        Console.WriteLine("Total: R$ " + total.ToString("F2"));
            //        break;

            //    case 4:
            //        total = b * 2.00;
            //        Console.WriteLine("Total: R$ " + total.ToString("F2"));
            //        break;

            //    case 5:
            //        total = b * 1.50;
            //        Console.WriteLine("Total: R$ " + total.ToString("F2"));
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();
            #endregion

            #region 18 Media aluno
            //double n1, n2, n3, n4, media, exame, examefinal;

            //string[] valores = Console.ReadLine().Split(' ');

            //n1 = double.Parse(valores[0]);
            //n2 = double.Parse(valores[1]);
            //n3 = double.Parse(valores[2]);
            //n4 = double.Parse(valores[3]);

            //media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            //Console.WriteLine("Media: " + media.ToString("F1"));

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aluno aprovado.");
            //}
            //else if (media < 5)
            //{
            //    Console.WriteLine("Aluno reprovado.");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno em exame.");
            //    exame = Convert.ToDouble(Console.ReadLine());
            //    examefinal = (exame + media) / 2;
            //    Console.WriteLine("Nota do exame: " + exame.ToString("F1"));
            //    Console.WriteLine("Aluno aprovado.");
            //    Console.WriteLine("Media final: " + examefinal.ToString("F1"));
            //}
            //Console.ReadLine();
            #endregion

            #region  19 Quadrantes

            //double x, y;

            //x = double.Parse(Console.ReadLine());
            //y = double.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0 && y < 0 )
            //{
            //    Console.WriteLine("Q3");
            //}
            //else if ( x > 0 && y < 0 )
            //{
            //    Console.WriteLine("Q4");
            //}
            //else if ( x < 0 && y > 0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if ( x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x == 0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else 
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //Console.ReadKey();
            #endregion

            #region 20 Sort

            double a, b, c;

            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            if (a < b && b < c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else if (a < c && c < b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else if (b < a && a < c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else if (b < c && c < a)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
            else if (c < a && a < b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
                 Console.WriteLine("\n" + a);
                 Console.WriteLine(b);
                 Console.WriteLine(c);

                 Console.ReadKey();
            #endregion


        }

    }
}
