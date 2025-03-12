using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Temas;

namespace Sistema_de_apoyo_al_aprendizaje
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Examen.Examenes.AddRange([
                new Examen(1),
                new Examen(2),
                new Examen(3)
                ]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Tema_1>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Examen? examen = Examen.Examenes.Find(examen => examen.Id == 1);

            if (examen != null && examen.EstaEvaluado)
            {
                Router.OpenForm<Tema_2>(this);
            }
            else MessageBox.Show("Debes realizar el test del tema 1 para acceder a este tema", "Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Examen? examen = Examen.Examenes.Find(examen => examen.Id == 2);

            if (examen != null && examen.EstaEvaluado)
            {
                Router.OpenForm<Tema_3>(this);
            }
            else MessageBox.Show("Debes realizar el test del tema 2 para acceder a este tema", "Info");
        }

        private void BtnCalificacionFinal_Click(object sender, EventArgs e)
        {
            if (Examen.TestCompletados())
            {
                decimal promedio = Examen.PromediarExamenes();
                string mensaje = promedio > 6
                    ? "¡Felicidades! Aprobaste"
                    : "Lo sentimos, has reprobado";
                

                MessageBox.Show($"Examenes Completados{Environment.NewLine}Tu calificación es {promedio.ToString("F2")} {Environment.NewLine}{mensaje}", "Calificación");
            } else
            {
                MessageBox.Show("Aun no completas todos los test", "Info");
            }
        }
    }
}
