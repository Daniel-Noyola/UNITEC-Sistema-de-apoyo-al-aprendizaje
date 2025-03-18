namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Router
    {
        public static Form? MainForm = Application.OpenForms["MenuPrincipal"];
        public static void OpenForm<T>(
            Form currentForm,
            Form? returnForm = null) where T : Form, new()
        {
            T form = new();

            if (currentForm != MainForm) currentForm.Close();

            if (returnForm != null) form.FormClosed += (s, args) => returnForm.Show();
            else form.FormClosed += (s, args) => MainForm?.Show();

            form.Show();
        }

        public static void GoToMainForm(Form currentForm)
        {
            currentForm.Close();
            MainForm?.Show();
        }
    }
}
