using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Delegados_multiples_handlers
{
    class CTienda
    {
        public static void MandaViveres(int opKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus viveres, estoy en la tienda");
            Console.WriteLine("-->Sera {0} kilos ", opKilos);
        }
    }
}
