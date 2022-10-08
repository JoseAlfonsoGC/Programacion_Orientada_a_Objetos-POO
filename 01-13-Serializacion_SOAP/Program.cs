using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace _01_13_Serializacion_SOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            //es necesario adicionar referencia a formatters.Soap
            int opcion = 0;

            Console.WriteLine("1) crear y serializar auto, 2) leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                //creamos el objeto CAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo = Convert.ToInt32(Console.ReadLine());

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a serializar ");
                miAuto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("--- Serializacion ---");

                //Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //Se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //serializamos 
                formateador.Serialize(miStream, miAuto);

                //cerramos el stream

                miStream.Close();

            }
            if (opcion == 2)
            {
                //deserializamos el objeto
                Console.WriteLine("---Deserializamos ---");

                //seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserializamos 
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                //Creamos el stream
                miStream.Close();

                //Usamos el objeto
                Console.WriteLine("El auto deserializado es ");
                miAuto.MuestraInformacion();
            }
            Console.ReadKey();
        }
    }
}
