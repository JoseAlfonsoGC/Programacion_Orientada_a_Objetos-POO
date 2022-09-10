using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_encapsulación
{
    class Program
    {
        static void Main(string[] args)
        {

            CCalcular op = new CCalcular();

            op.Nombre="José";
            op.Edad = 17;
            
            op.Muestra();

            Console.ReadLine();
        }
    }
}
