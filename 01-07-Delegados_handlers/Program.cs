using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_07_Delegados_handlers
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //adicionamos los handlers
            miRefri.AdicionaMetdoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            //el refri trabaja
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }


        }

        public static void InformeKilos(int opKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", opKilos);
        }

        public static void InformeGrados(int opGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->Se descongela el refri, Estoy a nivel de main");
            Console.WriteLine("--->Esta a {0} grados", opGrados);

        }
    }
}
