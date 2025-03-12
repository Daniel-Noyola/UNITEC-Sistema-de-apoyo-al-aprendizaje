namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Examen(int id)
    {
        public static List<Examen> Examenes = [];

        public int Id { get; } = id;
        public decimal Calificacion { get; set; }
        public bool EstaEvaluado { get; set; } = true;

        public static void CalificarExamen(int examenId, List<bool> respuestas)
        {
            Examen? examen = Examen.Examenes.Find(examen => examen.Id == examenId);
            int calificacion = 0;

            foreach (bool respuesta in respuestas)
            {
                if (respuesta) calificacion++;
            }

            if (examen != null)
            {
                examen.Calificacion = calificacion;
                examen.EstaEvaluado = true;
            }

            MessageBox.Show($"Tu calificación es: {calificacion}");
        }
    }
}
