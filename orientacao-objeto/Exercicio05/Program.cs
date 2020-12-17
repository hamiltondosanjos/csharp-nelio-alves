using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno01;
            aluno01 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno01.nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            aluno01.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota");
            aluno01.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a terceira nota");
            aluno01.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + aluno01.SomaNotas.ToString("F2"), CultureInfo.InvariantCulture);

            if (aluno01.SomaNotas <= 60)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + (60 - aluno01.SomaNotas) + " Pontos");
            }
            else
            {
                Console.WriteLine("Aprovado!");

            }

        }
    }
}
