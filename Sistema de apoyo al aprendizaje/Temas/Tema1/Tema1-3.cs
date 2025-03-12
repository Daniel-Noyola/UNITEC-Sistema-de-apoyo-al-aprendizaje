using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Tests;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema1
{
    public partial class Tema1_3 : Form
    {
        public Tema1_3()
        {
            InitializeComponent();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema1_2>(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Test1>(this);
        }
    }
}
