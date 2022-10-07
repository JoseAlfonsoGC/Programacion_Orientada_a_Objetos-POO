using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06_delegados_static
{
    class CRadio
    {
        //este metodo actuara como delegado
        public static void MetodoRadio(string opMensaje)//static garantiza que se pueda
                                                        //pueda utilizar el metodo aun
                                                        //si no es instanciada la clase CRadio 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje {0}", opMensaje);

        }
    }
}
