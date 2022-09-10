using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_00_herencia
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

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
        public void ponerDatos(string nombre, int edad, string puesto, double salario)
        {
            Nombre = nombre; //nos muestra la propiedad de la base no el atributo
            Edad = edad;

            this.puesto = puesto;
            this.salario = salario;

        }
        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabajo de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
