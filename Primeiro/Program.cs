using System;
using System.Globalization;


//##############################--PESQUISAS--################################
//| Convert.ToInt32:                                                         |
//| O método Console.ReadLine sempre interpreta como string                  |
//|o valor referenciado pelo usuario.                                       |
//|Para obter um valor inteiro do usuário,                                  |
//|essa string precisa ser convertida em Inteiro.                           |
//|e o metodo "Convert.ToInt32" faz a conversão para numero inteiro.        |
//|Pode se usar tbm o Int.Parse que ja faz a leitura de um numero inteiro.  |
//|                                                                         |
//|Operador Aritmético "%":                                                 |
//|"%" = MOD, tem como o objetivo identificar o resto de uma divisão,       |
//|exemplo: Se um numero é par a divisão dele por 2 não teria RESTO.        |
//|E se o numero for impar a divisão por 2 terá resto.                      |
//###########################################################################

//OBS:

//##############DIFERENÇA ENTRE int.parse e Convert.ToInt32###################
//|int.Parse é utilizado somente para converter string                       |
//|em int disparando uma Exception se o valor convertido for null,           |
//|(string vazia) ou qualquer caractere não numérico.                        |
//|                                                                          |    
//|Convert.ToInt32 é utilizado para converter outros tipos de objeto         |
//|(object, bool, string, etc) em um int,                                    | 
//|internamente ele utiliza int.Parse,                                       |
//|porem adicionando a feature de retornar zero se o valor                   |
//|convertido for null.													     |
//############################################################################
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            if (areaX > areaY)
            {
                Console.WriteLine("mAIOR Area: X");
            }else
            {
                Console.WriteLine("Maior Area: Y");
            }

            //exercicio 1

            //int numero = int.Parse(Console.ReadLine());

            //if (numero < 0)
            //{
            //    Console.WriteLine("Esté numero é negativo");
            //}
            //else
            //{
            //    Console.WriteLine("Este número não é negativo");
            //}

            //exercicio 2:
            //static void Main(string[] args)
            //{

            //    int numeroDeEntrada;

            //    Console.WriteLine("Insira um número");
            //    numeroDeEntrada = Convert.ToInt32(Console.ReadLine());

            //    if (numeroDeEntrada % 2 == 0)
            //    {
            //        Console.WriteLine("Numero par!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Numero impar!");
            //    }
            //}

            //exercicio 3
            //int numero1 = int.Parse(Console.ReadLine());
            //int numero2 = int.Parse(Console.ReadLine());

            //Ver o que deu errado neste codigo.
            //if (numero1 % numero2 == 0)
            //{
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else if (numero2 % numero1 == 0)
            //{
            //    Console.WriteLine("Nao sao Multiplos");
            //}
            //#############################################
            //if (numero2 % numero1 == 0)
            //{
            //    Console.WriteLine("São Multiplos");
            //}else
            //{
            //    Console.WriteLine("Não são multiplos");
            //}

            //exercicio 4
            //int inicio = int.Parse(Console.ReadLine());
            //int fim = int.Parse(Console.ReadLine());

            //int duracao = 24 - (24 + inicio - fim) % 24;

            //if (inicio == fim)
            //{
            //    Console.WriteLine("o jogo durou 24 horas");
            //}
            //else
            //{
            //    Console.WriteLine("O jogo dorou" + duracao + "horas");
            //}

            //int codigo = int.Parse(Console.ReadLine());
            //int quantidade = int.Parse(Console.ReadLine());

            //double total = 0;
            //if (codigo == 1)
            //{
            //    total = quantidade * 4.00;
            //}
            //else if (codigo == 2)
            //{
            //    total = quantidade * 4.50;
            //}
            //else if (codigo == 3)
            //{
            //    total = quantidade * 5.00;
            //}
            //else if (codigo == 4)
            //{
            //    total = quantidade * 2.00;
            //}
            //else if (codigo == 5)
            //{
            //    total = quantidade * 1.50;
            //}
            //else
            //{
            //    Console.WriteLine("Codigo Invalido!");
            //}

            //Console.WriteLine("Preço: " + total);


            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());

            //if (x == 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else if (y == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else
            //{
            //    Console.WriteLine("Q4");
            //}


            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (numero < 0.0 || numero > 100.0)
            //{
            //    Console.WriteLine("Fora do intervalo");
            //}
            //else if (numero <= 25.0)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (numero <= 50.0)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (numero <= 75.0)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}

            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0)
            //{
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}

        }
    }
}

