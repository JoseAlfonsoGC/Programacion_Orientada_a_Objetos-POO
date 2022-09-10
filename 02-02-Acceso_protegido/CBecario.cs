using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_Acceso_protegido
{
    class CBecario:CEmpleado //el error lo dejare y se puede solucionar quitando sealed de la clase empleado o dejando de tratar de que un becario sea un empleado
    {                        //becario puede ser un hijo de la clase persona sin problema
        private int horasBeca;

        //public CBecario(string nombre, int edad, string puesto, double salario)
        //    :base(nombre,edad,puesto,salario)
        //{

        //}

        public int HorasBeca { get { return horasBeca; } set { horasBeca = value; } }

        public void MuestraBecario()
        {
            EmpleadoMuestra();
            //Muestra();
            Console.WriteLine("Cantidad de horas: {0}", horasBeca);
        }
    }
}
