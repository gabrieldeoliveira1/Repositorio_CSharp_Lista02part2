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
    public partial class ProjetoClasse_Comparacao : Form
    {
        public ProjetoClasse_Comparacao()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_Comparacao_Load(object sender, EventArgs e)
        {
            Classe_Comparador_Projeto co = new Classe_Comparador_Projeto();
            MessageBox.Show("O maior número inteiro é de: " + co.Maior(8, 10));
            MessageBox.Show("O maior número decimal é de: " + co.Maior(8.9, 8.4));
        }
    }
}
