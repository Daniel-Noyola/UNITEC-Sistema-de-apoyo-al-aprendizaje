﻿namespace Sistema_de_apoyo_al_aprendizaje.Classes
{
    internal class Examen(int id)
    {
        public static List<Examen> Examenes = [
            new Examen(1),
            new Examen(2),
            new Examen(3),
            ];

        public int Id { get; } = id;
        public decimal Calificacion { get; set; }
        public bool EstaEvaluado { get; set; } = false;

        public static void CalificarExamen(int examenId, bool[] respuestas)
        {
            Examen? examen = Examenes.Find(examen => examen.Id == examenId);
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

        public static bool TestCompletados()
        {
            return !Examenes.Exists(examen => examen.EstaEvaluado == false);
        }

        public static decimal PromediarExamenes()
        {
            decimal resultado = 0;
            Examenes.ForEach(Examen =>
            {
                resultado += Examen.Calificacion;
            });

            return resultado / Examenes.Count;
        }
    }
}
