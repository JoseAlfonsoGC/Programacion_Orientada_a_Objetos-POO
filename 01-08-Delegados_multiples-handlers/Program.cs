using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Delegados_multiples_handlers
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //variables para el milticasting, necesario la intancia para poder adicionar o eliminar

            DReservasBajas kilos1 = new DReservasBajas(InformeGrados);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeGrados);

            //Adicionamos los handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);

            //el refri trabaja
            while (miRefri.kilos > 0)
            {
                miRefri.Trabajo(rnd.Next(1, 5));
            }

            //eliminamos un handler
            miRefri.EliminaMetodoReservas(kilos2);

            /////////////////////////////////////

            //Rellenamos el refri
            miRefri.kilos = 50;
            miRefri.Grados = -15;

            while (miRefri.kilos > 0)
            {
                miRefri.Trabajo(rnd.Next(1, 5));
            }
        }

        public static void InformeKilos(int opKIlos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", opKIlos);
        }
        public static void InformeGrados(int opGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->Se descongela el refri, estoy a nivel de main");
            Console.WriteLine("--->Esta a {0} grados", opGrados);
        }
    }
}
