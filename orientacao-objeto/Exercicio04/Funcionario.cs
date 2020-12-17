﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto * porcentagem / 100) + SalarioBruto - this.Imposto; 
        }
    }
}
