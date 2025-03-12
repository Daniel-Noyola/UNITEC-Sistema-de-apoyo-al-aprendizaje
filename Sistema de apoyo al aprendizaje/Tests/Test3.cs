using Sistema_de_apoyo_al_aprendizaje.Classes;
namespace Sistema_de_apoyo_al_aprendizaje.Tests
{
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            List<bool> respuestas = [
                Respuesta1.Checked,
                Respuesta2.Checked,
                Respuesta3.Checked,
                Respuesta4.Checked,
                Respuesta5.Checked,
                Respuesta6.Checked,
                Respuesta7.Checked,
                Respuesta8.Checked,
                Respuesta9.Checked,
                Respuesta10.Checked,
                ];

            Examen.CalificarExamen(3, respuestas);
            Close();
        }
    }
}
