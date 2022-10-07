using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_ICloneable_interfaz
{
    class CAuto:IAutomovil,ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        public CAuto(string opModelo, double opCosto)
        {
            costo = opCosto;
            modelo = opModelo;
        }

        public double Costo { get { return costo; } set { costo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        //Metodo interfaz
        public void CalculaTenencia(double opImpuesto)
        {
            tenencia = 5000.0 + costo * opImpuesto;
        }
        public void MuestraInformacion()
        {
            //MOstrar informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", Costo, Tenencia);
            Console.WriteLine("Total {0}", Costo + tenencia);
            Console.WriteLine("----------------------------");
        }

        //metodo para implementar a Icloneable
        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);

            temp.Tenencia = tenencia;
            return temp;
        }
    }
}
