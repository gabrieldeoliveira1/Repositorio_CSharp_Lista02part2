namespace Aula5_Pilares_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Classe_Calculadora_Projeto cl = new Classe_Calculadora_Projeto();
            MessageBox.Show("A soma dos valores é: " + cl.Soma(5, 4));
        }
    }
}
