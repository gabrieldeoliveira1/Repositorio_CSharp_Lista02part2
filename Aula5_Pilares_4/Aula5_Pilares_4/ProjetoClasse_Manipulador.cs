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
    public partial class ProjetoClasse_Manipulador : Form
    {
        public ProjetoClasse_Manipulador()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_Manipulador_Load(object sender, EventArgs e)
        {
            Classe_Manipulador_Projeto cp = new Classe_Manipulador_Projeto();
            MessageBox.Show("A mensagem é: " + cp.txt);
            MessageBox.Show("A mensagem de forma reversa é: " + cp.Inverter());
        }
    }
}