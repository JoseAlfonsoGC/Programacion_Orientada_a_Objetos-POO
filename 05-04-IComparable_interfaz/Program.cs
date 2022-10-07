using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_IComparable_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] rects = new CRectangulo[5];

            rects[0] = new CRectangulo(7, 4);
            rects[1] = new CRectangulo(6, 4);
            rects[2] = new CRectangulo(4, 3);
            rects[3] = new CRectangulo(7, 6);
            rects[4] = new CRectangulo(5, 7);

            //imprimimos el arreglo orinal
            foreach (CRectangulo r in rects)
                Console.WriteLine(r);
                
             Console.WriteLine("-------------------");

                //Hacemos uso de sort, el cual necesita la implementacion de IComparable
                Array.Sort(rects);

                //Imprimimos arreglo ordenado
                foreach (CRectangulo r in rects)
                    Console.WriteLine(r);

            Console.ReadKey();
                
            
        }
    }
}
