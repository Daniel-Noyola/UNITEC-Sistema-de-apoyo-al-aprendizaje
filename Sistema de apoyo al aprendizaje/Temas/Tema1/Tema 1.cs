using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje
{
    public partial class Tema_1 : Form
    {
        public Tema_1()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }
    }
}
