using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_00_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int opcion;

            //sin polimorfismo, queda concreto a la clase

            Console.WriteLine("Que mascota quieres? 1-Gato 2-Reptil");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                CGato migato = new CGato();
                migato.Nombre = "Scraft";
                migato.Moverse();
            }
            else if (opcion == 2)
            {
                CReptil mireptil = new CReptil();
                mireptil.Nombre = "Zuipy";
                mireptil.Moverse();
            }

            Console.WriteLine("----------------------------");

            //uso del polimorfismo
            //con el polimorfismo, el codigo se concentra en el concepto no en la clase
            Console.WriteLine("Que mascota quieres? 1-Perro, 2-Pez, 3-Ave");
            opcion = Convert.ToInt32(Console.ReadLine());

            //Creamos la variables que tendran polimorfismo
            CAnimal miMascota = new CAnimal();

            //dependiendo de la seleccion le damos el comportamiento.
            if (opcion == 1)
                miMascota = new CPerro();
            if (opcion == 2)
                miMascota = new CPez();
            if (opcion == 3)
                miMascota = new CAve();
            //Ahora trabajamos en terminos del concepto Animal y no en terminos de clases especificas
            Console.WriteLine("Dame el nombre");
            miMascota.Nombre = Console.ReadLine();

            miMascota.Moverse();

            Console.ReadLine();
        }
    }
}
