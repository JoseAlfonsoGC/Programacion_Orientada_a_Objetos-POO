using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_ICloneable_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto AutoUno = new CAuto("March", 170000);

            //la clonacion es obtener 2 objetos con el mismo estado, despues de esto cada uno puede modificar su estado.
            /************************************************************** clonacion falsa***********/
            //Aqui pensamos que hemos clonado
            //pero solo e otra variable referenciada a la misma instancia
            CAuto AutoDos = AutoUno; 

            AutoUno.CalculaTenencia(0.10);
            AutoDos.CalculaTenencia(0.10);

            //Imprimimos
            AutoUno.MuestraInformacion();
            AutoDos.MuestraInformacion();

            Console.WriteLine("----------------------");

            //Hacemos un cambio, si fuera un clon solo uno cambia

            AutoUno.Costo = 60000;

            //Imprimimos
            AutoUno.MuestraInformacion();
            AutoDos.MuestraInformacion();

            Console.WriteLine("----------------------");

            //************************************************************** clanacion ******************************
            /*En la clase auto esta la implementacion de la interfaz*/

            CAuto autoTres = (CAuto)AutoUno.Clone();

            AutoUno.MuestraInformacion();//la informacion es la misma
            autoTres.MuestraInformacion();
            Console.WriteLine("----------------------");

            AutoUno.Costo = 250000;
            //modificamos para verificar
            AutoUno.MuestraInformacion();
            autoTres.MuestraInformacion();
            Console.WriteLine("----------------------");
        }
    }
}
