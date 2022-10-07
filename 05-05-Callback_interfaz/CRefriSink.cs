using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_Callback_interfaz
{
    class CRefriSink:IEventosRefri
    {
        private bool paro = false;

        public bool Paro { get { return paro; } }

        //aqui colocamos los handlers de los eventos definicdos en la interfaz
        public void EReservasBajas(int opKilos)
        {
            //necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos ", opKilos);
        }
        public void EDesconjelado(int opGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->El refri se descongela");
            if (opGrados > 0)
            {
                paro = true;
            }
        }
    }
}
