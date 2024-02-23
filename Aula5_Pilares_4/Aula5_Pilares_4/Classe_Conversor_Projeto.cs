using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_Conversor_Projeto
    {
        public double conversao;
        public double conversao1;
        public double dolar;
        public double real;
        public double Dol(int rel)
        {

          
            dolar = rel / 4.97;
            conversao = dolar;

            return conversao;
        }

        public double Rel()
        {

            real = dolar * 4.97;

            conversao1 = real;
            return conversao1;
        }
    }
}