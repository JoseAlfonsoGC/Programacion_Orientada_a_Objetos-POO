using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_IComparable_interfaz
{
    class CRectangulo:IComparable
    {
        private double ancho, alto, area;

        public CRectangulo(double opAncho, double opAlto)
        {
            ancho = opAncho;
            alto = opAlto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }
        public override string ToString()
        {
            return string.Format("[{0}.2]-{2}", ancho, alto, area);
        }

        //implementacion de IComparable
        int IComparable.CompareTo(object obj)
        {
            //Hcaemos type cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            //si somos mas grandes que el objeto regresamos 1
            if (area > temp.area)
                return 1;

            //si somos pequeños que el objeto regresa -1
            if (area < temp.area)
                return -1;

            // somos iguales al objeto regesamos 0
            return 0;
        }
    }
}
