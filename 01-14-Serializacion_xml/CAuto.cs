using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_14_Serializacion_xml
{
    [Serializable]
    //la clase es publica
    public class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { set { costo = value; } get { return costo; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }

        //constructor si parametros si se ocupa serializacion de xml
        public CAuto()
        {
            costo = 100000;
            modelo = "Chevy";
        }
         
        public void MuestraInformacion()
        {
            //mostramos informacion necesaria
            Console.WriteLine("Tu Auto {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("----------------------");
        }
    }
}
