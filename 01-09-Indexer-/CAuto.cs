using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09_Indexer_
{
    class CAuto
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string opModelo, double opCosto)
        {
            costo = opCosto;
            modelo = opModelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu Auto {0}", modelo);
            Console.WriteLine("costo {0} ", costo);
            Console.WriteLine("-----------------------");
        }
    }
}
