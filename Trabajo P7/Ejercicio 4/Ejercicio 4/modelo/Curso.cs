using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.modelo
{
    internal class Curso
    {/* Una universidad desea crear un sistema para la gestion de cursos y estudiantes.
         Cada curso tiene un codigo, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre
         numero de matricula y el año de cursado. El sistema debe permitir la inscripcion y des inscripcion de estudiantes
         en cursos, asi como la visualizacion de la lista de estudiantes por curso. Identifica los objetos, atributos y 
         metodos necesarios para implementar este sistema.*/
        private int codigo;
        private string nombre;
        private string profesor;
        private string materia;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public string Materia { get => materia; set => materia = value; }

        public void Mostrarinfo()
        {
            Console.WriteLine("Codigo de curso: " + codigo);
            Console.WriteLine("Nombre del curso: "+ nombre);
            Console.WriteLine("El profesor es: "+profesor);
            Console.WriteLine("La materia es: "+materia);
        }
    }
}
