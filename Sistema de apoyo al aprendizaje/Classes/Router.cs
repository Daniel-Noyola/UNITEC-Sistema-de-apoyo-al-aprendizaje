namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Router
    {
        public static void OpenForm<T>(
            Form currentForm,
            Form? returnForm = null) where T : Form, new()
        {
            T form = new();
            Form? mainForm = Application.OpenForms["MenuPrincipal"];

            if (currentForm == mainForm) currentForm.Hide();
            else currentForm.Close();

            if (returnForm != null) form.FormClosed += (s, args) => returnForm.Show();
            else form.FormClosed += (s, args) => mainForm?.Show();

            form.Show();
        }

        public static void GoToMainForm(Form currentForm)
        {
            currentForm.Close();
            Form? mainForm = Application.OpenForms["MenuPrincipal"];
            mainForm?.Show();

        }
    }
}
