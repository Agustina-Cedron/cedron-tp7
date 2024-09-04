using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.modelo
{
    internal class Pedido
    /*Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/
    {
        private string identificador;
        private string fechapedido;
        private int preciototal;
        private string usuario;

        public string Identificador { get => identificador; set => identificador = value; }
        public string Fechapedido { get => fechapedido; set => fechapedido = value; }
        public int Preciototal { get => preciototal; set => preciototal = value; }
        internal string Usuario { get => usuario; set => usuario = value; }

        public void Mostrarinfo() 
        {
            Console.WriteLine("Identificador del pedido: "+identificador);
            Console.WriteLine("Fecha del pedido: "+fechapedido);
            Console.WriteLine("Precio total $: "+preciototal);
            Console.WriteLine("Cliente: "+ usuario);
        }
    }
}
