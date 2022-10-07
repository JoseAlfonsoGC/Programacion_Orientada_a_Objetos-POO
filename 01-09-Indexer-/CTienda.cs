using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_Indexer_
{
    class CTienda
    {
        private CAuto[] disponibles;

        public CTienda()
        {
            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 175600.70);
            disponibles[2] = new CAuto("March", 168900.00);
            disponibles[3] = new CAuto("Spark", 160400.40);
        }

        //Aqui creamos el index
        public CAuto this[int indice]
        {
            //Usamos un get para obtene el elemento en ese indice
            get { return disponibles[indice]; }
            //usamos set para colocar un elemento en ese indice
            set { disponibles[indice] = value; }
        }
    }
}
