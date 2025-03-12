using Sistema_de_apoyo_al_aprendizaje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_apoyo_al_aprendizaje.Tests
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            Examen.CalificarExamen(1, respuestas);
            Close();
        }
    }
}
