using Ejercicio_1.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados. Los
usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si están registrados,
pueden pedir prestados los libros. Los libros pueden estar disponibles en formato digital o físico.
Cada vez que un usuario pide prestado un libro, se registra la fecha de préstamo y la fecha de
devolución prevista. Además, la biblioteca tiene un sistema para enviar recordatorios a los
usuarios cuando se acerca la fecha de devolución de un libro.*/
            

            Libro biblioteca=new Libro();
            biblioteca.Nombredelibro = "Bajo la misma estrella";
            biblioteca.Autor = "Jhon Green";
            biblioteca.Fechadeprestamo = "05/05/24";
            biblioteca.Fechadedevolucion = "28/06/24";
            biblioteca.Mostrarinfo();
            Console.WriteLine("----------------------------------------------------");
            Usuario persona = new Usuario();
            persona.Nombre = "Maria ";
            persona.Apellido = "Suarez";
            persona.Direccion = "Rivadavia920";
            
            persona.MostrarInfo();
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
