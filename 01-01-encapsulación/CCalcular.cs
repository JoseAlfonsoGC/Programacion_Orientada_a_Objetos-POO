using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_encapsulación
{
    class CCalcular
    {
        //Encapsulamiento/Data hiding
        //al cambiar los atributos y los metodos en una sola entidad (obtenemos la encapsulacion) 
        //los objetos no necesariamente necesitan revelar sus atributos y comportamientos
        //solo mostramos al exterior aquellos con los que otros objetos van a interactuar

        //acceso
        //public es accesible del exterior 
        //private oculta aquello  que el exteriro no necesita saber, solo el mismo objeto puede acceder
        //protegido -unicamente dentro de la cadena de herencia se tiene acceso

        //Data Hiding
        //es el tipo de restriccion el acceso a los atributos.

        //para usar metodos que el exterior pueda invocar hacemos uso de "Accesor"
        //-     Permite el acceso a los datos internos del objeto
        //-     esconden como se obtuvo ese dato 
        //*variable
        //*combinacion de variable
        //*calculado de alguna forma
        //-     se presenta de muchas formas
        //funciones de interfase, getter y setter
        //propiedades

        private string nombre;
        private int edad;

        public string Nombre { set { nombre = value; } }
        //se puede colocar un control para el uso de set
        public int Edad { set {
                if (edad <= 18)
                    edad = value;
                else
                    edad = 0;
            } 
        }

        public void Muestra()
        {
            Console.WriteLine("Nombre: {0}, edad:{1}", nombre, edad.ToString());
        }
    }
}
