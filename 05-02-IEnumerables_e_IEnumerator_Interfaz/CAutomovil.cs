using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_IEnumerables_e_IEnumerator_Interfaz
{
    class CAutomovil : IAutomovil
    {
        double costo;
        double tenecia;
        string modelo;

        public CAutomovil(string pModelom, double pCosto)
        {
            costo = pCosto;
            modelo = pModelom;
        }

        public void CalcularTenencia(double OPimp)
        {
            tenecia = 5000.0 + costo * OPimp;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenecia);
            Console.WriteLine("Total {0}", costo + tenecia);
            Console.WriteLine("------------");
        }
    }
}
