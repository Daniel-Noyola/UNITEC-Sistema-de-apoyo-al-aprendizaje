using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Temas.Tema3;

namespace Sistema_de_apoyo_al_aprendizaje.Temas
{
    public partial class Tema_3 : Form
    {
        public Tema_3()
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
            Router.OpenForm<Tema3_2>(this);
        }
    }
}
