using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Retangulo r01;
            r01 = new Retangulo();

            Console.WriteLine("Digite a largura: ");
            r01.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a altura: ");
            r01.altura  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: " + r01.Area().ToString("F2", CultureInfo.InvariantCulture));
           
            Console.WriteLine("Perimetro: " + r01.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: "  + r01.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
