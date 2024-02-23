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
    public partial class ProjetoClasse_Matematica : Form
    {
        public ProjetoClasse_Matematica()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_Matematica_Load(object sender, EventArgs e)
        {
            Classe_Matematica_Projeto mt = new Classe_Matematica_Projeto();
            MessageBox.Show("A soma dos valores é de: " + mt.Calcular());
            MessageBox.Show("A média dos valores é de: " + mt.Calcular(8));
        }
    }
}