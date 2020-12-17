using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);

            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));

            
        }
    }
}
