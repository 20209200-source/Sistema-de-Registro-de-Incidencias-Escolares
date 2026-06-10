using System;

namespace SistemaRegistroIncidencias
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
    }

    public class Profesor
    {
        public string Nombre { get; set; }
    }

    public class Incidencia
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string AccionTomada { get; set; }

        public Estudiante Estudiante { get; set; }
        public Profesor Profesor { get; set; }
    }

    public class SeguimientoController
    {
        public void MostrarSeguimiento(Incidencia incidencia)
        {
            Console.WriteLine("===== SEGUIMIENTO DE INCIDENCIA =====");
            Console.WriteLine($"Estudiante: {incidencia.Estudiante.Nombre}");
            Console.WriteLine($"Matrícula: {incidencia.Estudiante.Matricula}");
            Console.WriteLine($"Profesor Responsable: {incidencia.Profesor.Nombre}");
            Console.WriteLine($"Fecha: {incidencia.Fecha.ToShortDateString()}");
            Console.WriteLine($"Incidencia: {incidencia.Descripcion}");
            Console.WriteLine($"Acción Tomada: {incidencia.AccionTomada}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Juan Pérez",
                Matricula = "20250001"
            };

            Profesor profesor = new Profesor
            {
                Nombre = "María Rodríguez"
            };

            Incidencia incidencia = new Incidencia
            {
                Descripcion = "Llegó tarde a clases",
                Fecha = DateTime.Now,
                AccionTomada = "Advertencia verbal",
                Estudiante = estudiante,
                Profesor = profesor
            };

            SeguimientoController seguimiento = new SeguimientoController();
            seguimiento.MostrarSeguimiento(incidencia);
        }
    }
}
