using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_15_Serializacion_con_composicion
{
    [Serializable]
    public class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;

        public double Costo { set { costo = value; } get { return costo; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }
        public CMotor Motor { set { motor = value; } }
        public CAuto()
        {
            costo = 100000;
            modelo = "Chevy";
            motor = new CMotor();
        }
        public void MuestraInformacion()
        {
            //mostramos informacion necesaria
            Console.WriteLine("Tu Auto {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            motor.MuestraMotor();
            Console.WriteLine("----------------------");
        }
    }
}
