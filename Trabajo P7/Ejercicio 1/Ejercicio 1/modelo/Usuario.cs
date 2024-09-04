﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.modelo
{
    internal class Usuario
    {
        private string nombre;
        private string apellido;
        private string direccion;
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del usuario registrado: " + nombre);
            Console.WriteLine("Apellido del usuario registrado: " + apellido);
            Console.WriteLine("La direccion es: "+ direccion);
           

        }

    }
}
