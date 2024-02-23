using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_Matematica_Projeto
    {
        public double retornar = 0;
        public double retornar1 = 0;
        public double soma=0 ;

        public double Calcular()
        {
            int[] num = new int[3] { 5, 5, 5 };

            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }

            return soma;
        }

        public double Calcular(int calc)
        {
            
                retornar1 = soma / 3;

            return retornar1;

        }


        }
    }


