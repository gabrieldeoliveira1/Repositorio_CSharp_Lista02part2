namespace Aula5_Pilares_4
{
    public partial class ProjetoClasse_Calculadora : Form
    {
        public ProjetoClasse_Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Classe_Calculadora_Projeto cl = new Classe_Calculadora_Projeto();
            MessageBox.Show("A soma dos valores inteiros �: " + cl.Soma(5, 4));
            MessageBox.Show("A soma dos valores decimais �: " + cl.Soma(5.5, 6.7));
        }
    }
}
