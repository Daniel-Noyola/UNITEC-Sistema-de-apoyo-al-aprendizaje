using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Temas.Tema2;

namespace Sistema_de_apoyo_al_aprendizaje
{
    public partial class Tema_2 : Form
    {
        public Tema_2()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema2_2>(this);
        }
    }
}
