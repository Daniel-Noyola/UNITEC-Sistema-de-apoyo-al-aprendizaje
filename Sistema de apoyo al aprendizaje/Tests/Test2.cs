using Sistema_de_apoyo_al_aprendizaje.Classes;

namespace Sistema_de_apoyo_al_aprendizaje.Tests
{
    public partial class Test2 : Form
    {
        public readonly List<GroupBox> Boxes = [];
        public Test2()
        {
            InitializeComponent();
            ControlPreguntas();
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

            Examen.CalificarExamen(2, respuestas);
            Close();
        }

        public void ControlPreguntas()
        {
            Boxes.AddRange([
                groupBox1,
                groupBox2,
                groupBox3,
                groupBox4,
                groupBox5,
                groupBox6,
                groupBox7,
                groupBox8,
                groupBox9,
                groupBox10,
                ]);

            Boxes.ForEach(box =>
            {
                if (box == Boxes[0]) return;
                box.Enabled = false;
            });

            Guardar1.Click += (s, args) => HabilitarPregunta(1);
            Guardar2.Click += (s, args) => HabilitarPregunta(2);
            Guardar3.Click += (s, args) => HabilitarPregunta(3);
            Guardar4.Click += (s, args) => HabilitarPregunta(4);
            Guardar5.Click += (s, args) => HabilitarPregunta(5);
            Guardar6.Click += (s, args) => HabilitarPregunta(6);
            Guardar7.Click += (s, args) => HabilitarPregunta(7);
            Guardar8.Click += (s, args) => HabilitarPregunta(8);
            Guardar9.Click += (s, args) => HabilitarPregunta(9);
            Guardar10.Click += (s, args) => HabilitarPregunta(10);
        }

        public void HabilitarPregunta(int id)
        {
            if (id != 0) Boxes[id - 1].Enabled = false;
            if (id == 10)
            {
                BtnEnviar.Enabled = true;
                return;
            }

            Boxes[id].Enabled = true;
        }
    }
}
