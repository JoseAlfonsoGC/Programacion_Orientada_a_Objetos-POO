using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_00_clase_constructor_metodo_s
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, y=0;

            Console.WriteLine("Ingresa el primer valo: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valo: ");
            y = Convert.ToDouble(Console.ReadLine());

            Ccalcula op = new Ccalcula(x, y);

            op.Suma();
            op.Muestra();
            
            Console.ReadLine();
        }
    }
}
