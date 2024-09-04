using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Libro
    {
        private string fechadeprestamo;
        private string fechadedevolucion;
        private string nombredelibro;
        private string autor;

        public string Fechadeprestamo { get => fechadeprestamo; set => fechadeprestamo = value; }
        public string Fechadedevolucion { get => fechadedevolucion; set => fechadedevolucion = value; }
        public string Nombredelibro { get => nombredelibro; set => nombredelibro = value; }
        public string Autor { get => autor; set => autor = value; }
        public void Mostrarinfo()
        {
            Console.WriteLine("La fecha de prestamo es: "+ fechadeprestamo);
            Console.WriteLine("La fecha de devolucion es: " + fechadedevolucion);
            Console.WriteLine("El nombre del libro es: " + nombredelibro);
            Console.WriteLine("El autor del libro: "+autor);
        }
    }
    
}
