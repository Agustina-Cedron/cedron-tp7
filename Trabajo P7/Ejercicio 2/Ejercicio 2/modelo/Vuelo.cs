using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.modelo
{
    internal class Vuelo
    {
        private int numerovuelo;
        private string fechavuelo;
        private string destino;
        private int precio;

        public int Numerovuelo { get => numerovuelo; set => numerovuelo = value; }
        public string Fechavuelo { get => fechavuelo; set => fechavuelo = value; }
        public string Destino { get => destino; set => destino = value; }
        public int Precio { get => precio; set => precio = value; }

        public void Mostrarinfo()
        {
            Console.WriteLine("El numero de vuelo es: " + Numerovuelo);
            Console.WriteLine("El nombre del destino es: " + Destino);
            Console.WriteLine("El precio del vuelo es $: " + Precio);
            Console.WriteLine("La fecha del vuelo es: " + Fechavuelo);


        }
    }
}

    
