using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_16_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Console.WriteLine("1) crear archivo, 2) leer archivo");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();
                Console.WriteLine("Dame el costo");
                costo = Convert.ToInt32(Console.ReadLine());

                CAuto miAuto = new CAuto(modelo, costo);

                //variables extras
                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //crea el escribir
                BinaryWriter write = new BinaryWriter(fs);

                //escribir los estados del objeto 
                //ojo no estamos serializando

                write.Write(miAuto.Modelo);
                write.Write(miAuto.Costo);
                //escribimos las variables
                write.Write(numero);
                write.Write(acceso);
                write.Write(conteo);

                fs.Close();
            }
            if (opcion == 2)
            {
                Console.WriteLine("--- Lemos archivo ---");

                Stream fs = new FileStream("Miarchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                //creamos el lector
                BinaryReader lector = new BinaryReader(fs);

                //leemos en el mismo orden que se escribio
                //tomando en cuenta el tipo

                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto miAuto = new CAuto(modelo, costo);

                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();

                fs.Close();

                miAuto.MuestraInfromacion();
                Console.WriteLine("numero {0}", numero);
                Console.WriteLine("acceso {0}", acceso);
                Console.WriteLine("conteo {0}", conteo);
            }
            Console.ReadKey();
        }
    }
}
