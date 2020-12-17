using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            Console.WriteLine("Digite: \n1 - Alcool\n2 - Gasolina\n3 - Diesel\n4 para finalizar");
            int tipo = int.Parse(Console.ReadLine());

            while(tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                if (tipo == 2)
                {
                    gasolina++; 
                }
                if (tipo == 3)
                {
                    diesel++;
                }

                Console.WriteLine("Continuar");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("diesel: " + diesel);
        }
    }
}
