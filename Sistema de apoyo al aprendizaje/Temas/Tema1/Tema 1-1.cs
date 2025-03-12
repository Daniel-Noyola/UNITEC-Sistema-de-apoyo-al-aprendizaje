using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Temas.Tema1;

namespace Sistema_de_apoyo_al_aprendizaje
{
    public partial class Tema_1 : Form
    {
        public Tema_1()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema1_2>(this);
        }
    }
}
