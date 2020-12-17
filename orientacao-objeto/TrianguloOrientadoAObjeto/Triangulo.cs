using System;

namespace TrianguloOrientadoAObjeto
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        //Quando quero que função não tenha retorno coloco 'void'
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
