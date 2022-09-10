using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_Composicion_Ejemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos a la escuela
            CEscuela miEscuela = new CEscuela("Programacion y diseño Web");
            //creamos los objetos de aula, que existen adentro de escuela
            miEscuela.ColocaAulas();

            //mostramos el objeto compuesto
            Console.WriteLine(miEscuela);

            //si eliminamos la instancia no hay forma de tener las aulas 
            miEscuela = null;
            Console.ReadLine();
        }
    }
}
