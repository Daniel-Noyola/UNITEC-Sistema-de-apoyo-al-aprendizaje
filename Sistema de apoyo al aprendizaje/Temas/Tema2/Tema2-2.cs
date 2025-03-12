using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema2
{
    public partial class Tema2_2 : Form
    {
        public Tema2_2()
        {
            InitializeComponent();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema_2>(this);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema2_3>(this);
        }
    }
}
