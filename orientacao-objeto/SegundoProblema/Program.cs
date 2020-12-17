using System;
using System.Globalization;

namespace SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque");
            int qnt = int.Parse(Console.ReadLine());
            p.AddProdutos(qnt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque");
            qnt = int.Parse(Console.ReadLine());
            p.DelProdutos(qnt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado " + p);

        }
    }
}
