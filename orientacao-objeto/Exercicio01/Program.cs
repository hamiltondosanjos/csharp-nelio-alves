using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p01, p02;
            p01 = new Pessoa();
            p02 = new Pessoa();

            Console.WriteLine("01- Entre com o nome ");
            p01.nome = Console.ReadLine();
            Console.WriteLine("01- Entre com a idade ");
            p01.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("02- Entre com nome");
            p02.nome = Console.ReadLine();
            Console.WriteLine("02- Entre com a idade");
            p02.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + p01.nome);
            Console.WriteLine("Nome: " + p01.idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + p02.nome);
            Console.WriteLine("Nome: " + p02.idade);

            if(p01.idade > p02.idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + p01.nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha é: " + p02.nome);
            }



        }
    }
}
