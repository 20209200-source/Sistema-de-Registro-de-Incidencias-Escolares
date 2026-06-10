using System;

namespace SistemaRegistroIncidencias
{
    // Controlador de Estudiantes
    public class EstudianteController
    {
        public void RegistrarEstudiante()
        {
            Console.WriteLine("Estudiante registrado correctamente.");
        }

        public void ConsultarEstudiante()
        {
            Console.WriteLine("Consulta de estudiante realizada.");
        }
    }
    public class ProfesorController
    {
        public void RegistrarProfesor()
        {
            Console.WriteLine("Profesor registrado correctamente.");
        }

        public void ConsultarProfesor()
        {
            Console.WriteLine("Consulta de profesor realizada.");
        }
    }
    public class IncidenciaController
    {
        public void RegistrarIncidencia()
        {
            Console.WriteLine("Incidencia registrada correctamente.");
        }

        public void ConsultarIncidencias()
        {
            Console.WriteLine("Consulta de incidencias realizada.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EstudianteController estudiante = new EstudianteController();
            ProfesorController profesor = new ProfesorController();
            IncidenciaController incidencia = new IncidenciaController();

            estudiante.RegistrarEstudiante();
            profesor.RegistrarProfesor();
            incidencia.RegistrarIncidencia();
        }
    }
}
