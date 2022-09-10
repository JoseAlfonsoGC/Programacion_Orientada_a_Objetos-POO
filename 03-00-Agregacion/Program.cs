using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_00_Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Agregación-----------en UML es represantado por un-------◊ rombo vacío
            /*
            {
            -si la clase hija no necesita de su totalidad de metodos y atributos de la clase padre puede descartar tales para su estructura
            -su existencia no depende de la clase padre
            }
             */
            //ejemplo de agregacion
            //creamos al propietario
            CPropietario jose = new CPropietario("Jose");

            //creamos la propiedad
            CEdificio edif1 = new CEdificio("Av. 1 num 56", 10, 3);

            //vemos info del propietario
            jose.MostrarPropiedad();
            //le colocamos la propiedad
            jose.AdicionaPropiedad(edif1);
            jose.MostrarPropiedad();

            //Eliminar a Jose
            jose = null;
            GC.Collect();
            //jose.MostrarPropiedad();
            Console.WriteLine("----------------");

            //verificamos el edificio exista independientemente de Jose
            edif1.Muestra();
            Console.ReadLine();
        }
    }
}
