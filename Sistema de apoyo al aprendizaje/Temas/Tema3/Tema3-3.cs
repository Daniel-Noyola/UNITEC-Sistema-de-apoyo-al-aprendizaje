using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Tests;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema3
{
    public partial class Tema3_3 : Form
    {
        public Tema3_3()
        {
            InitializeComponent();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema3_2>(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Test3>(this);
        }
    }
}
