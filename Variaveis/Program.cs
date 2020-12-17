using System;
using System.Globalization;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double duplo = 4.58356;
            string name = "Hamilton";
            Object obj1 = "Cássia";
            Object obj2 = "Vic";
            int idade = 35; 

            int n10 = int.MinValue;
            int n20 = int.MaxValue;

            Console.WriteLine(name);
            //ToString: Limita o número de caractere depois do ponto flutuante, além de arredondar no número
            Console.WriteLine(duplo.ToString("F2"));
            //CultureInfo.InvariantCulture:  Transforma a vírgula em ponto
            Console.WriteLine(duplo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} Reais", name, idade, duplo);
            Console.WriteLine($"{name} tem {idade} anos e tem saldo igual a {duplo:F2} reais");

            Console.WriteLine(name + " tem " + idade + " anos e tem saldo igual a " + duplo.ToString("F2", CultureInfo.InvariantCulture) + " Reais");

            string s = Console.ReadLine();

            //Split separa uma cadeia de caracter
            string[] vet = s.Split(' ');
            //ou
            //string[] vet = Console.ReadLine();.Split('');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


        }
    }
}
