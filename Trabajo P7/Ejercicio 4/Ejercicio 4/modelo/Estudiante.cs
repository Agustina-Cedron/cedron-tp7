using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.modelo
{
    internal class Estudiante
    {/* Una universidad desea crear un sistema para la gestion de cursos y estudiantes.
         Cada curso tiene un codigo, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre
         numero de matricula y el año de cursado. El sistema debe permitir la inscripcion y des inscripcion de estudiantes
         en cursos, asi como la visualizacion de la lista de estudiantes por curso. Identifica los objetos, atributos y 
         metodos necesarios para implementar este sistema.*/
        private string nombre;
        private int numeromatricula;
        private int aniocursado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numeromatricula { get => numeromatricula; set => numeromatricula = value; }
        public int Aniocursado { get => aniocursado; set => aniocursado = value; }

        public void Mostrarinfo() 
        {
            Console.WriteLine("Nombre del alumno: " + nombre);
            Console.WriteLine("Numero de matricula: "+numeromatricula);
            Console.WriteLine("Año cursado: " + aniocursado);
        }
    }
}
