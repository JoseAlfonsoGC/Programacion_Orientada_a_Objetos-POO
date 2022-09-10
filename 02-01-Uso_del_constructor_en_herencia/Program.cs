using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_Uso_del_constructor_en_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Ejemplo herencia esando constructores---");
            //ejemplo 01
            CPersona uno = new CPersona("Maria", 28);

            uno.Muestra();
            Console.WriteLine("----------");
            //ejemplo 02
            CEmpleado dos = new CEmpleado("Jose", 30, "Contador", 10500.50);

            dos.EmpleadoMuestra();
            Console.WriteLine("----------");

            //ejemplo 03
            CEmpleado tres = new CEmpleado("Susana", 25, "Programador", 150000.30);

            tres.EmpleadoMuestra();
            Console.WriteLine("----------");

            tres.ponerDatos("Susana", 23, "Programador Senior", 180000.70);
            tres.EmpleadoMuestra();
            Console.ReadLine();
        }
    }
}
