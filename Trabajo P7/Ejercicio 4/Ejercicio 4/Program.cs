using Ejercicio_4.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Una universidad desea crear un sistema para la gestion de cursos y estudiantes.
         Cada curso tiene un codigo, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre
         numero de matricula y el año de cursado. El sistema debe permitir la inscripcion y des inscripcion de estudiantes
         en cursos, asi como la visualizacion de la lista de estudiantes por curso. Identifica los objetos, atributos y 
         metodos necesarios para implementar este sistema.*/
            Curso aula = new Curso();
            aula.Codigo = 2478;
            aula.Nombre = "7mo Info";
            aula.Profesor = "Sandra Guzman";
            aula.Materia = "Lengua";
            aula.Mostrarinfo();
            Console.WriteLine("----------------------------------------------------");
            Estudiante alumno = new Estudiante();
            alumno.Nombre = "Maite Caceres";
            alumno.Numeromatricula = 2034;
            alumno.Aniocursado = 2024;
            alumno.Mostrarinfo();
            Console.WriteLine("-----------------------------------------------------");
            Profesor profe = new Profesor();
            profe.Nombre = "Sandra Guzman";
            profe.Asignatura = "Lengua";
            profe.Direccion = "Av. Gutierrez Pedraza ";
            
            profe.Mostrarinfo();
            Console.ReadKey();

        }
    }
}
