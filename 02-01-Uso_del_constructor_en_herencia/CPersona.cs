using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_Uso_del_constructor_en_herencia
{
    class CPersona
    {

        private string nombre = "";
        private int edad;
        public CPersona(string nombre, int edad)
        {
            Console.WriteLine("Constructor de persona");
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
        }
        public void Muestra()
        {
            Console.WriteLine("{0} tiene {1} años", nombre, edad);
        }
    }
}
