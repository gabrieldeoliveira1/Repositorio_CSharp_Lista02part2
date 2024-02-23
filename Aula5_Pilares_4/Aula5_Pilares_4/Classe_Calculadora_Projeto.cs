using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_Calculadora_Projeto
    {
        public int val1;
        public int val2;
        public int Soma(int v1, int v2)
        {
            int Somar = v1 + v2; 
            return Somar;
        }

        public double Soma(double v1, double v2)
        {
            double Somar = v1 + v2;
            return Somar;
        }
    }
}
