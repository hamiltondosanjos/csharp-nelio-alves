using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("___________________");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine("___________________");

            if (c5 = c6 && 4 > 5)
            {
                Console.WriteLine("Ok");
            }

            bool c9 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c9);

            bool c10 = 10 < 5;
            bool c11 = c1 || c2 && c3;

            Console.WriteLine(c10);
            Console.WriteLine(c11);
        }
    }
}
