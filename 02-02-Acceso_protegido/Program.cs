using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_Acceso_protegido
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            //hacemos uso de la clase persona
            CPersona op = new CPersona();

            Console.WriteLine("NOmbre");
            op.Nombre = Console.ReadLine();
            Console.WriteLine("Edad");
            op.Edad = Convert.ToInt32(Console.ReadLine());

            op.Muestra();
            Console.WriteLine("------------------");
            //uso de la clase empleado que es un hijo de persona
            CEmpleado op2 = new CEmpleado();
            op2.Nombre = "Susana";
            op2.Edad = 23;
            op2.Puesto = "Programador";
            op2.Salario = 30000;
            op2.EmpleadoMuestra();
            Console.WriteLine("---------------------");
            //uso de la clase becario que trata de tomar los atributos de la clase empleado
            //y es posible pero becario no es un empleado, ya tenemos un problema generado por los atributo protegido
            //la solucion es sellar la clase con sealed. el cual se tiene que escribir en donde se declara la clase que se quiere sellar
            
            CBecario op3 = new CBecario();
            op3.Nombre = "Jose";
            op3.Edad = 27;
            op3.Puesto = "Desarrollador web";
            op3.Salario = 50000;
            op3.HorasBeca = 8;
            op3.MuestraBecario();

            Console.ReadLine();
        }
    }
}
