using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
   public class Classe_ManipuladorLista_Projeto
    {
    
        public int[] RemoverElemento(int[] num, int num1)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == num1)
                    num[i] = 0;
            }
            return num;
        }
       
    }
}