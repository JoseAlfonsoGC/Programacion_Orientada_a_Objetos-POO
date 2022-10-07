using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_IEnumerables_e_IEnumerator_Interfaz
{
    class CFormaPersonalizadaContenedora:IEnumerable
    {
        private int[] valores = new int[10];

        public CFormaPersonalizadaContenedora()
        {
            for (int n = 0; n < 10; n++)
            {
                valores[n] = n * n;
            }
        }

        //impementamos el GetEnumerator necesario por IEnumerable 
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Instanciamos el enumerator y lo regresamos 
            return (new ContenedorEnum(valores));
        }

    }
    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] opArreglo)
        {
            arreglo = opArreglo;
        }
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get { return arreglo[posicion]; }
        }
    }
}
