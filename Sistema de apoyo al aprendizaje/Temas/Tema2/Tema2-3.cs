using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema2
{
    public partial class Tema2_3 : Form
    {
        public Tema2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Router.GoToMainForm(this);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema2_2>(this);
        }
    }
}
