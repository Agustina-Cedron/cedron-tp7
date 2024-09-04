using Ejercicio_2.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una compañía aérea desea implementar un sistema de gestión de vuelos. Los vuelos tienen un
número, una fecha de salida, un destino y un precio. Los pasajeros tienen un nombre, número
de pasaporte y nacionalidad. Se requiere un programa que permita gestionar los vuelos,
incluyendo la adición y eliminación de vuelos, así como la gestión de los pasajeros en cada
vuelo. Identifica los posibles objetos, atributos y métodos necesarios para implementar este
sistema.*/
           Vuelo vuelos1=new Vuelo();
            vuelos1.Numerovuelo = 54;
            vuelos1.Destino="Inglaterra";
            vuelos1.Precio=8000000;
            vuelos1.Fechavuelo="18 de agosto de 2024";
            vuelos1.Mostrarinfo();
            Console.WriteLine("-------------------------------------------------------");
            Pasajero usuario = new Pasajero();
            usuario.Nombrep="Manuel Segovia";
            usuario.Nacionalidad = "Argentino";
            usuario.Numerop=135;
            usuario.Mostrarinfo();
            Console.ReadKey();

                
        }
    }
}
