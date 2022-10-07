using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_Serializacion_Binaria
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto(string opModelo, double opCosto)
        {
            costo = opCosto;
            modelo = opModelo;
        }

        public void MuestraInformacion()
        {
            //mostramos informacion necesaria
            Console.WriteLine("Tu Auto {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("----------------------");
        }
    }
}
