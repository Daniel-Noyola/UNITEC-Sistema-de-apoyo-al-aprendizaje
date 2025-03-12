using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Temas;

namespace Sistema_de_apoyo_al_aprendizaje
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examen.OpenTest<Tema_1>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Examen.OpenTest<Tema_2>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Examen.OpenTest<Tema_3>(this);
        }
    }
}
