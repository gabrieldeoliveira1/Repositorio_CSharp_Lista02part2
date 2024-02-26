using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_Manipulador_Projeto
    {
        public string txt = "Olá, Mundo!";
        public string txtreverse = "";

        public string Inverter()
        {
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                txtreverse += txt[i];
               
            }

            return txtreverse;
        }


    }
}
