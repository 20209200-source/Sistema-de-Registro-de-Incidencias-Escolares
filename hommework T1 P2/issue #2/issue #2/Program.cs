using System;

namespace SistemaRegistroIncidencias
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
    }

    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
    }

    public class Incidencia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoIncidencia { get; set; }
        public string AccionTomada { get; set; }

        public int EstudianteId { get; set; }
        public int ProfesorId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entidades creadas correctamente.");
        }
    }
}