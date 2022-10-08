using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_17_Stream_uso_de_Seek_ReadByte_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            //obtenemos la cantidad
            cantidad = fs.Length;
            Console.WriteLine("El archivo mode {0}", cantidad);

            //leemos byte por byte

            for (n = 0; n < cantidad; n++)
            {
                //pones la posicion
                fs.Seek(n, SeekOrigin.Begin);
                valor = fs.ReadByte();

                Console.Write(" {0} ", (char)valor);
            }

            Console.WriteLine("\n----------------------------\n");
            //leemos ahora en el otro sentido
            for (n = 1; n <= cantidad; n++)
            {
                //ponemos la posicion
                fs.Seek(-n, SeekOrigin.End);
                valor = fs.ReadByte();
                Console.Write(" {0} ", (char)valor);
            }

            Console.WriteLine("\n-----------------------\n");

            fs.Seek(0, SeekOrigin.Begin);//seek permite seleccionar un byte en la cadena

            //leer sin conocer la longitud
            while ((valor = fs.ReadByte()) > 0)
            {
                Console.Write(" {0} ", (char)valor);
            }


            fs.Close();
            Console.ReadKey();
        }
    }
}
