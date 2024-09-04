using Ejercicio_3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        /*Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/

        {

            Producto producto1=new Producto();
            producto1.Nombre = "Cereal Mix";
            producto1.Precio = 250;
            producto1.Descripcion = "sabor manzana verde";
            producto1.Cantidad = 12;
            producto1.Mostrarinfo();
            Console.WriteLine("------------------------------------------------");
            Usuario persona =new Usuario();
            persona.Nombre = "Lucia Roldan";
            persona.Direccion = "9 de julio";
            persona.Correo = "luciroldan27@gmail.com";
            persona.Mostrarinfo();
            Console.WriteLine("------------------------------------------------");
            Pedido pedido1 = new Pedido();
            pedido1.Identificador ="9376583";
            pedido1.Fechapedido = "13/06/24";
            pedido1.Preciototal = 3000;
            pedido1.Usuario = "Lucia Roldan";
           
            pedido1.Mostrarinfo();
            Console.ReadKey();
        }
    }
}
