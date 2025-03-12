using Sistema_de_apoyo_al_aprendizaje.Classes;
using Sistema_de_apoyo_al_aprendizaje.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Router.OpenForm<Test3>(this);
        }
    }
}
