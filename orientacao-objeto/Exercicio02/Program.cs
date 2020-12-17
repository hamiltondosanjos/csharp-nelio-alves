using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f01, f02;
            f01 = new Funcionario();
            f02 = new Funcionario();
            double media;

            Console.WriteLine("Dados do Primeiro Funcionário");
            Console.WriteLine("Nome: ");
            f01.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f01.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Segundo Funcionário");
            Console.WriteLine("Nome: ");
            f02.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f02.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Primeiro Funcionário");
            Console.WriteLine("Nome: " + f01.nome);
            Console.WriteLine("Salário: " + f01.salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do Segundo Funcionário");
            Console.WriteLine("Nome: " + f02.nome);
            Console.WriteLine("Slário: " + f02.salario.ToString("F2", CultureInfo.InvariantCulture));

            media = (f01.salario + f02.salario) / 2;

            Console.WriteLine("Salário médio = " + media);


        }
    }
}
