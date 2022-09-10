using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_Composicion_Ejemplo_01
{
    class CEscuela
    {
        private string nombre;
        private CAulas[] aula = new CAulas[3];//aqui selleva a cabo la composicion
                                              //en su interior hay 3 instancias de tipo Aula, sin la clase Escuela la clase Aula no existe
        public CEscuela(string nombre)
        {
            this.nombre = nombre;
        }
        public void ColocaAulas()
        {
            int n = 0;
            string nombre = "";
            int cantidad = 0;

            for (n = 0; n < aula.Length; n++)
            {
                Console.WriteLine("Dame el nombre del aula");
                nombre = Console.ReadLine();

                Console.WriteLine("Dame la cantidad de alumnos");
                cantidad = Convert.ToInt32(Console.ReadLine());
                //a qui es donde se lleva a acabo parte de la composicion y usan la instaancia de Aulas
                aula[n] = new CAulas(nombre, cantidad);
            }
        }
        public override string ToString()
        {
            string mensaje = "";
            int n = 0;

            mensaje = string.Format("Bienvenidos a la escuela {0}, la cual consta de \r\n", nombre);
            for (n = 0; n < aula.Length; n++)
            {
                mensaje += aula[n].ToString() + "\r\n";
            }
            return mensaje;
        }
    }
}
