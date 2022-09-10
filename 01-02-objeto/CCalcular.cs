using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_objeto
{
    class CCalcular
    {
        //private solo la clase puede trabajar con el atributo
        private double r;
        //public permite a el exterior modificar su valor del atributo
        //los atributos publicos no se ocupan con frecuencia, representan un riesgo para el sistema que se esta desarrollando
        public double a;
        public double b;
        //ambito de objeto
        string ambito_a_Nivel_de_Opjeto = "";
        public void Suma()
        {
            r = a + b;
            //ambito local
            string ambitoLocalEnSuma = "";//un atributo con el mismo nombre es declarado en Multiplicado, no es el mismo porque se encuentra en un bloque distinto
                                          //el uso de this especifica que se usara un atributo del exterior del metodo que este dentro de la clase
            this.ambito_a_Nivel_de_Opjeto = ambitoLocalEnSuma;
        }
        public void Multiplicador()
        {
            r = a * b;
            string ambitoLocalEnSuma="";
        }

        public void Muestra()
        {
            string ambitoLocalEnSuma;
            Console.WriteLine("a= {0} + b= {1}, r={2}", a.ToString(), b.ToString(), r.ToString());
        }
    }
}
