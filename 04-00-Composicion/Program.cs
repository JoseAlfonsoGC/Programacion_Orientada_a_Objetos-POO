using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_Composicion
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------composicion y agregacion soy muy similares-------------------
            //Composición ----en UML es represantado por un-----⧫ rombo relleno hacia a la clase principal
            /*
            {
            -El objeto se construye usando otros objetos
            -si la clase principal no existe la clase secundaria
            -Relación tiene-un
            }
             */
            //ejemplo de composición

            //creamos al propietario
            CPropietario Ana = new CPropietario("Ana");
            //Mostramos la propiedad
            Ana.MostrarPropiedad();
            Console.WriteLine("----------");

            //tratar de no ocupar propiedades get, set que ...v
            //esto rompe con la encapsulacion
            //tratamos de acceder a la propiedad
            CEdificio edif = Ana.Propiedad;
            edif.Muestra();
            Console.WriteLine("----------");

            //otro problema que no tenemos que ocupar en la composición, eliminamos el objeto CPropietario
            Ana = null;
            GC.Collect();

            Console.ReadLine();
        }
    }
}
