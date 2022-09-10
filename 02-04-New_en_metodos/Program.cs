using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04_New_en_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //uso de new en metodos 
            //nos permite poner codigo propio a metodos no virtuales 
            //pero perdemos polimorfismo

            CProductoImportado miProducto = new CProductoImportado("Motocicleta", 45000, 0.15);

            //y si es util, cuando ya existe una clase y se quiere modificar un metodo que no sea virtual

            miProducto.CalculaPrecio();
            miProducto.MuestraVenta();

            Console.WriteLine("-----------------");

            CProducto p1 = new CProducto("Television", 10500);
            p1.CalculaPrecio();
            p1.MuestraVenta();

            Console.WriteLine("-----------------");

            CProducto p3 = new CProductoImportado("Bicicleta", 2200, 0.2);
            p3.CalculaPrecio();
            p3.MuestraVenta();

            Console.ReadLine();
        }
    }
}
