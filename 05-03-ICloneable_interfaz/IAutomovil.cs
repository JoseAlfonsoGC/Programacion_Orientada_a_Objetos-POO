using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_ICloneable_interfaz
{
    interface IAutomovil
    {
        //calcula el impuesto
        void CalculaTenencia(double imp);
        //Mostrar informacion
        void MuestraInformacion();
    }
}
