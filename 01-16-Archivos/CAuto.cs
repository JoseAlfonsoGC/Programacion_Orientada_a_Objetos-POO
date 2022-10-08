using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_16_Archivos
{
    class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        public CAuto(string opModelo, double opCosto)
        {
            costo = opCosto;
            modelo = opModelo;
        }

        public void MuestraInfromacion()
        {
            Console.WriteLine("Tu Automovil {0}", Modelo);
            Console.WriteLine("Costo {0} ", costo);
            Console.WriteLine("-----------------------");
        }
    }
}
