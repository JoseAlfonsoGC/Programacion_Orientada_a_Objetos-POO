using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_Polimorfismo_Interfase
{
    interface IOperacion
    {
        void Calcular(double a, double b);
        void Mostrar();
    }
}
