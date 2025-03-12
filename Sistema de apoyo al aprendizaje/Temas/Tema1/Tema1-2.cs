using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema1
{
    public partial class Tema1_2 : Form
    {
        public Tema1_2()
        {
            InitializeComponent();

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema_1>(this);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema1_3>(this);
        }
    }
}
