using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_IEnumerables_e_IEnumerator_Interfaz
{
    class Program
    {
        /*
         public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }

        public interface IEnumerator
        {
            bool MoveNext();
            object Current { get;}
            void Reset();
        }
         */
        static void Main(string[] args)
        {
            /*establecido por iEnumerable para trabajar con foreach 
            CTiendaAutos opCtiendaAutos = new CTiendaAutos();

            foreach (CAutomovil auto in opCtiendaAutos)
            {
                auto.CalcularTenencia(0.05);
                auto.MuestraInformacion();
            } */

            //Ejemplo sin el uso de iEnumerable y iEnumerator

            CFormaPersonalizadaContenedora datos = new CFormaPersonalizadaContenedora();
            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }
            Console.ReadKey();
        }
    }
}
