using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5_Pilares_4
{
    public partial class ProjetoClasse_CalcGeom : Form
    {
        public ProjetoClasse_CalcGeom()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_CalcGeom_Load(object sender, EventArgs e)
        {
            Classe_CalcGeom_Projeto cg = new Classe_CalcGeom_Projeto();
            MessageBox.Show("A área do retângulo é de: " + cg.Area(6, 6));
            MessageBox.Show("A área do círculo: " + cg.Area(6));
            MessageBox.Show("A área do triângulo: " + cg.Area(6, 6, 0));
        }
    }
}