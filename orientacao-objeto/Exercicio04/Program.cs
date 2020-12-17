using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func01;
            func01 = new Funcionario();

            Console.Write("Nome: ");
            func01.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func01.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Imposto: ");
            func01.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário" + func01.Nome + ", R$ " + func01.SalarioLiquido());

            Console.Write("Digite as porcentagem para aumentar o salário: ");

            double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func01.AumentarSalario(porcento);

            Console.WriteLine("Dados atualizado: " + func01.Nome + ", R$" + func01.SalarioBruto);




        }
    }
}
