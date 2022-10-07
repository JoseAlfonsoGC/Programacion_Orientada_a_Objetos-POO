using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_Callback_interfaz
{
    class CTiendaSink:IEventosRefri
    {
        public void EReservasBajas(int opKilos)
        {
            //Aqui colocamos todo el codigo necesario para ejecutar cuendo suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--->Le ENVIAREMOS SUS VIVERES");
            Console.WriteLine("--->Sera {0} kilos ", opKilos);
        }

        public void EDesconjelado(int opGrados)
        {
            //handler vacion
        }
    }
}
