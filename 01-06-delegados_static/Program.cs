using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06_delegados_static
{
    //definicion del delegado con las caracteristicas que nos interesa
    public delegate void MiDelegado(string m);//despues del "delegate" se define la estructura de los metodos a los que se puede hacer referencia
                                              //"void MiDelegado(string m)" serian metodos que no regresan nada "void" y que requieren de un dato
    class Program
    {
        static void Main(string[] args)
        {
            //creamos un objeto del delegado y lo referenciamos a un metodo
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            //Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola a todos");

            //Hacemos que apunte a otro metodo
            delegado = new MiDelegado(CPastel.MostrarPastel);

            //Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");
        }
    }
}
