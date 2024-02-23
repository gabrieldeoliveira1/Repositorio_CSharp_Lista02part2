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
    public partial class ProjetoClasse_Conversor : Form
    {
        public ProjetoClasse_Conversor()
        {
            InitializeComponent();
        }

        private void ProjetoClasse_Conversor_Load(object sender, EventArgs e)
        {
            Classe_Conversor_Projeto cn = new Classe_Conversor_Projeto();
            MessageBox.Show("A conversão de reais para dolares é de: R$" + cn.Dol(8));
            MessageBox.Show("A conversão de dolares para reais é de: $ " + cn.Rel());
        }
    }
}

