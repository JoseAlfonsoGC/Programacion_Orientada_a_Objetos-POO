using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_00_Polimorfismo
{
    class CAve:CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine("El ave {0} vuela", nombre);
        }
    }
}
