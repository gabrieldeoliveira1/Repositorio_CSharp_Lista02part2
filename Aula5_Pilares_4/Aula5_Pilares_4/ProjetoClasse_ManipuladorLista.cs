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
    public partial class ProjetoClasse_ManipuladorLista : Form
    {
        public ProjetoClasse_ManipuladorLista()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_ManipuladorLista_Load(object sender, EventArgs e)
        {
            Classe_ManipuladorLista_Projeto ml = new Classe_ManipuladorLista_Projeto();
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ret = new int[10];

            ret = ml.RemoverElemento(num, 8);
            MessageBox.Show("O novo elemento é: " + ret[7].ToString());
        }
    }
   
}