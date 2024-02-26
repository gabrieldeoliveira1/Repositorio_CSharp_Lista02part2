using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Pilares_4
{
    internal class Classe_CalcGeom_Projeto
    {
        public double larg1;
        public double alt1;
        public double area_ret;
        public double area_tri;
        public double area_circ;
        public double larg2;
        public double alt2;
        public double raio;
        public double return1;
        public double return2;

        public double Area(double larg1, double alt1)
        {
            area_ret = larg1 * alt1;
            return area_ret;
        }

        public double Area(double larg2, double alt2, int return1)
        {
            area_tri = larg2 * alt2 / 2;
            return area_tri;
        }

        public double Area(double raio)
        {
            area_circ = (raio * raio) * 3.14;
            return area_circ;
        } 

    }

    
}
