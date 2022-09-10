using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_05_Static_brebe_explicacion_ambito
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------Ámbito---------
            //Ámbito o Scope: el ámbito es la regíon dentro del programa en donde es reconocido y puede usado un elemento: objeto, clase, atributo, funcion, metodo.
            /*
            -los atributos pueden tener tres niveles de ambito:
             Local
             Objeto
             Clase
             */
            //Ámbito local
            /*
            -se declara adentro de un método
            -solo ese método conoce el atributo
             */
            //Ámbito de objeto
            /*
            -se declara adentro de la clase 
            -todos los metodos en esa clase conocen y pueden usar a ese atributo
            -si algún método tiene uan variable con el mismo nombre, hacemos uso del this para distinguirlos
             */
            //Ámbito de clase
            /*
            -el atributo es compartido por dos o más objetos de la misma clase
            -se crea por medio de static
             */
            //ejemplo atributos estáticos
            CComputadora computadora1 = new CComputadora();
            CComputadora computadora2 = new CComputadora("i5", 4, 450);
            CComputadora computadora3 = new CComputadora("i7", 8, 670);

            computadora1.TipoCambio = 15.70;
            //Mostramos
            computadora1.MuestraDolares();
            computadora1.MuestraPesos();
            Console.WriteLine("-------");

            computadora2.MuestraDolares();
            computadora2.MuestraPesos();
            Console.WriteLine("-------");

            computadora3.MuestraDolares();
            computadora3.MuestraPesos();
            Console.WriteLine("-------");

            //hacemos el cambio, debe de reflejarse en todo
            Console.WriteLine("=====================================");

            computadora1.TipoCambio = 18.80;

            //mostramos
            computadora1.MuestraDolares();
            computadora1.MuestraPesos();
            Console.WriteLine("-------");

            computadora2.MuestraDolares();
            computadora2.MuestraPesos();
            Console.WriteLine("-------");

            computadora3.MuestraDolares();
            computadora3.MuestraPesos();
            Console.WriteLine("-------");


            Console.ReadLine();
        }
    }
}
