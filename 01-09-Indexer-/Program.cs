using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_Indexer_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            //creamos la tienda
            CTienda miTienda = new CTienda();

            //obtenemos un auto
            CAuto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            //colocamos un auto
            CAuto otroAuto = new CAuto("Vocho", 85000);
            miTienda[1] = otroAuto;

            //Imprimimos toda la tienda
            for (n = 0; n < 4; n++)
            {
                miTienda[n].MuestraInformacion();
            }
        }
    }
}
