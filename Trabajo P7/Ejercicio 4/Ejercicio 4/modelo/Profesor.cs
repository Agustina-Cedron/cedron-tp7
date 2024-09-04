using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.modelo
{
    internal class Profesor
    {
        private string nombre;
        private string asignatura;
        private string direccion;
       

        public string Nombre { get => nombre; set => nombre = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
        public string Direccion { get => direccion; set => direccion = value; }
       

        public void Mostrarinfo() 
        {
            Console.WriteLine("Nombre del profesor: "+ nombre);
            Console.WriteLine("Asigantura: "+asignatura);
            Console.WriteLine("Direccion: "+ direccion);
          
        }
    }
}
