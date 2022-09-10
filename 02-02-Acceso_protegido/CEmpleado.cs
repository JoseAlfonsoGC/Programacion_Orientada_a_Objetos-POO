using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_Acceso_protegido
{
    sealed class CEmpleado:CPersona 
    {
        //todas las clases que esten dentro de la herencia pueden tener acceso a los atributos (protected)
        //el tipo protected puede que rompa un poco con la herencia
        protected string puesto;
        protected double salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        //public void ponerDatos(string pnombre, int edad, string puesto, double salario)
        //{
        //    Nombre = pnombre; //nos muestra la propiedad de la base no el atributo
        //    Edad = edad;
        //    //con el acceso protegido podemos usar el atributo de la clase persona(padre), solo que rompe las reglas de la herencia
        //    nombre = pnombre;
        //    this.puesto = puesto;
        //    this.salario = salario;
        //}
        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabajo de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
