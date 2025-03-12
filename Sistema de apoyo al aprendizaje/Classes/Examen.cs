namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Examen(int id)
    {
        public static List<Examen> Examenes = [];

        public int Id { get; } = id;
        public decimal Calificacion { get; set; }
        public bool Evaluado { get; set; } = false;

        public static void OpenTest<T>(Form currentForm) where T : Form, new()
        {
            T test = new();
            test.FormClosed += (s, args) => currentForm.Show();
            currentForm.Hide();

            test.Show();
        }
    }
}
