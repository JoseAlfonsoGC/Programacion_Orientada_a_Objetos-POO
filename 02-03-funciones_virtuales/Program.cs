using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_funciones_virtuales
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo de funcion virtual y override con sealed

            //creamos producto
            CProducto uno = new CProducto("Bicicleta", 2500.35);

            uno.CalculaPrecio();
            uno.MuestraVenta();

            Console.WriteLine("-------------");
            //creamos producto importado
            CProductoImportado dos = new CProductoImportado("Bicicleta importada", 2500.35, 0.15);

            dos.CalculaPrecio();
            dos.MuestraVenta();

            Console.WriteLine("-------------");
            //creamos un producto con multa
            CProductoDetenido tres = new CProductoDetenido("Bici detenida", 2500.35, 0.15, 500.8);
            //si al ocupar sealed ya no podemos usar el metodo con override no quedara de otra mas quer ocupar el de una clase que si lo permita
            tres.CalculaPrecio();
            tres.MuestraVenta();

            Console.ReadLine();
        }
    }
}
