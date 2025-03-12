using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Examen
    {

        public static bool Exam1passed, Exam2passed, Exam3passed;

        public static void OpenTest<T>(Form currentForm) where T : Form, new()
        {
            T test = new T();
            test.FormClosed += (s, args) => currentForm.Show();
            currentForm.Hide();

            test.Show();
        }
    }
}
