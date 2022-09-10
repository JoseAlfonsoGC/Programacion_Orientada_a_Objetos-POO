using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_Composicion
{
    class CPropietario
    {
        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string nombre)
        {
            this.nombre = nombre;
            propiedad = new CEdificio("Av 2 numero 32", 7, 4);
        }
        public void MostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.Write("{0} tiene ", nombre);
                propiedad.Muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades ", nombre);
            }
        }
        //cuidado con esto rompe el encapsulamiento 
        public CEdificio Propiedad { get { return propiedad; } set { propiedad = value; } }
    }
}
