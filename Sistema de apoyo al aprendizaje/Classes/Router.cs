using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Router
    {
        public static void OpenForm<T>(
            Form currentForm,
            Form? returnForm = null) where T : Form, new()
        {
            T form = new();

            if (returnForm != null)
            {
                form.FormClosed += (s, args) => returnForm.Show();
                currentForm.Close();
            }
            else
            {
                form.FormClosed += (s, args) => currentForm.Show();
                currentForm.Hide();
            }

            form.Show();
        }

        public static void GoToMainForm(Form currentForm)
        {
            currentForm.Close();
            Form? mainForm = Application.OpenForms["MenuPrincipal"];
            if (mainForm != null)
            {
                mainForm.Show();
            }

        }
    }
}
