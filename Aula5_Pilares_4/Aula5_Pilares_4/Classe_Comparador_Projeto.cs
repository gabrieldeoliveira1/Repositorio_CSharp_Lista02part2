using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_Comparador_Projeto
    {
        public int num;
        public int num2;
        public double num3;
        public double num4;
        public double resultado;


        public double Maior(int num, int num2)
        {
            if (num > num2)
            {
                resultado = num;
            }
            else
            {
                resultado = num2;
            }
            return resultado;
        }

        public double Maior(double num3, double num4)
        {
            if (num3 > num4)
            {
                resultado = num3;
            }
            else
            {
                resultado = num4;
            }
            return resultado;
        }



    }


}