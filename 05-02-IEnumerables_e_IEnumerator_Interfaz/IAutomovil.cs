using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_IEnumerables_e_IEnumerator_Interfaz
{
    interface IAutomovil
    {
        //calcular el impusto
        void CalcularTenencia(double imp);

        //Mostrar informacion
        void MuestraInformacion();
    }
}
