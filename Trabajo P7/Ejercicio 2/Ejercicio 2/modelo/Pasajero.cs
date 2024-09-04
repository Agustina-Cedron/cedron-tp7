using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.modelo
{
    internal class Pasajero
    {
        private string nombrep;
        private string nacionalidad;
        private int numerop;

        public string Nombrep { get => nombrep; set => nombrep = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Numerop { get => numerop; set => numerop = value; }

        public void Mostrarinfo()
        {
            Console.WriteLine("El nombre del pasajero es: " + Nombrep);
            Console.WriteLine("La nacionalidad es: " + Nacionalidad);
            Console.WriteLine("El numero de pasaporte es: " + Numerop);
        }
    }
}
