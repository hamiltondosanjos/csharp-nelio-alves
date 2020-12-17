using System;

namespace Exercicio03
{
    class Retangulo
    {
        public double largura;
        public double altura;
        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (largura * 2) + (altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura*largura + altura*altura);
        }
    }
}
