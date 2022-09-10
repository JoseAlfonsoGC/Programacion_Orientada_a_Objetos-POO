using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_clases_abstractas_e_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //clase abstracta: son distintas a las clases normales, se define un concepto, aun que se pueden definir algunos metodos no podemos hacer instancias directas de ella
            //las clase hijas concretas son las que podemos ocupar con mas normalidad y se pueden instanciar
            /*
            {
            -------en terminos similares--------
            -Es una clase que tiene uno o más métodos que no han sido implementados.
            -Las clases abstracta no puede instanciarse
            -Las clases hijas se encargan de la implementación
            }
             */
            //Métodos abstractos y concretos
            /*
            Se llega a dar cuando las clase hijas usan ese mismo comportamiento y puede que de diferente forma, a modo de simplificar codigo
            y tambien hay metodos concretos para interaccion en las clases abstractas si asi lo requiere.
             */
            /*
            {
            //Entendiendo la interfaces difenrentes a las que antes se an explicados (interfaz grafica o interfaz publica del objeto)

            -En este caso nos referimos a un contrato entre clases
            -Sólo indica comportamientos, no como se lleva a cabo
            -No puede proveer ninguna implementación
            -Alguna clase implementa a la interfaz
            }
             */

            //Ejemplo del uso de Abstract
            /*
            CProducto miProducto = new CProducto("Bicicleta", 3500);//no podemos instanciar una clase abstracta, se tiene que crear clases concretas para porde hacerlo
            */
            CProductoImportado miProImp = new CProductoImportado("Motocicleta", 350000, 0.15);
            CProductoDetenido miProdDet = new CProductoDetenido("Televisor", 15000, 0.15, 0.30);
            miProImp.CalculaPrecio();
            miProdDet.CalculaPrecio();

            miProImp.MuestraVenta();
            miProdDet.MuestraVenta();

            Console.ReadLine();
        }
    }
}
