using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_18_Parametros_Nombrados_y_Opcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //invocamos la funcion de forma normal
            //tres posiciones 
            mostrarDatos(3, 5, 7);


            //Invocamos la funcion con primero en normal y los demas en otro ordeb
            //un posicional, dos nombrados
            mostrarDatos(3, pC: 11, pB: 15);

            //Invocamos los datos en otro orden 
            //tres nombrados
            mostrarDatos(pB: 10, pC: 15, pA: 4);

            //un posicional no puede venir despues de un nombrado
            //mostrarDatos(pB: 5, 7, 8);

            Console.WriteLine("Ahora con parametros opcionales");

            //invocamos normal
            mostrarOpcionales(11, 12, 13);

            //usamos dos parametros c usa el opcional
            mostrarOpcionales(20, 21);

            //usamos un parametro b y c usan el opcional

            mostrarOpcionales(31);

            //usamos todos los parametros opcionales
            mostrarOpcionales();

            Console.WriteLine("Ahora con nombrados y opcionales");

            //un opcional con dos nombrados
            mostrarOpcionales(pC: 67, pB: 45);

            //dos opcionales con un nombrado
            mostrarOpcionales(pB: 56);
            Console.ReadKey();
        }
        public static void mostrarDatos(int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("---------------------------");
        }

        public static void mostrarOpcionales(int pA = 1, int pB = 2, int pC = 3)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("---------------------------");
        }
    }
}
