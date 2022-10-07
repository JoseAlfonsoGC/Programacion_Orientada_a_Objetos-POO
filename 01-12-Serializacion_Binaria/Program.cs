﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_Serializacion_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Console.WriteLine("1) crear y serializar auto, 2) leer auto");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                //creamos el objeto auto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo = Convert.ToDouble(Console.ReadLine());

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("--- Serializacion ---");

                //seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                //se crea el stream
                Stream miStream = new FileStream("Auto.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //serializamos 
                formateador.Serialize(miStream, miAuto);

                //Cerramos el stream
                miStream.Close();
            }
            if (opcion == 2)
            {
                //deserializamos el objeto
                Console.WriteLine("---Deserializamos ---");

                //seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                //creamos el stream
                Stream miStream = new FileStream("Auto.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Deserializamos 
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                //Creamos el stream
                miStream.Close();

                //Usamos el objeto
                Console.WriteLine("El auto deserializado es ");
                miAuto.MuestraInformacion();
            }
        }
    }
}
