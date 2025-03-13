using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema3
{
    public partial class Tema3_2 : Form
    {
        public Tema3_2()
        {
            InitializeComponent();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema_3>(this);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema3_3>(this);
        }
    }
}
