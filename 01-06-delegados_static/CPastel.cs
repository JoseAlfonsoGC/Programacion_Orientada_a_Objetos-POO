using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06_delegados_static
{
    class CPastel
    {
        //Este metodo actuara como delegado
        public static void MostrarPastel(string opAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel lleva el mensaje de {0}", opAnuncio);
        }
    }
}
