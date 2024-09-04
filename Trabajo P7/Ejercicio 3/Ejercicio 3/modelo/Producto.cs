using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.modelo
{
    internal class Producto
    {
        /*Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/
        private string nombre;
        private int precio;
        private string descripcion;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public void Mostrarinfo() 
        {
            Console.WriteLine("Nombre del producto: "+ nombre);
            Console.WriteLine("Precio del producto $: "+precio);
            Console.WriteLine("Descripcion del producto: "+descripcion);
            Console.WriteLine("Cantidad de productos: "+cantidad);
        }
    }
}
