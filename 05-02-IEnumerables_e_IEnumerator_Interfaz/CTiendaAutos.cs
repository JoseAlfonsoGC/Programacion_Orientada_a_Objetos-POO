using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_IEnumerables_e_IEnumerator_Interfaz
{
    class CTiendaAutos
    {
        private CAutomovil[] disponibles;
        public CTiendaAutos()
        {
            disponibles = new CAutomovil[4];

            disponibles[0] = new CAutomovil("vocho", 200000);
            disponibles[1] = new CAutomovil("Firt", 500000);
            disponibles[2] = new CAutomovil("March", 190000);
            disponibles[3] = new CAutomovil("Spark", 240000);
        }

        public IEnumerator GetEnumerator()
        {
            //regresamos la cadena que nos interesa que recorra el forecha, esta debe de implementar IEnumerator
            return disponibles.GetEnumerator();
        }
    }
}
