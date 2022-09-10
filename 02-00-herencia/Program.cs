using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_00_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           //Herencia --------------→ en diagramas UML flecha apuntando a la clase padre
           -Adquiere los comportamientos y atributos de otra clase
           -Relación es-un
            */
            //ojo la herencia debilita la encapsulación
            /*
            {
            -la encapsulacion es fuerte con relación a otras clases.
            -la encapsulación es débil entre el padre y el hijo
            -si cambias la super clae, ese cambio afecta a todos los hijos.
            -Esto puede crear problemas inesperados
            -si hay un cambio es necesario hacer test de todas las clases hijas
            }
             */
            /*
             en siguientes proyectos se explicara el uso de 
                -composicion y agregacion
             */
            //objeto de la clase persona
            CPersona op1 = new CPersona();
            op1.Nombre = "Pedro";
            op1.Edad = 25;
            op1.Muestra();
            Console.WriteLine("----------");
            
            
            //creamos un objeto de empleado
            CEmpleado op2 = new CEmpleado();
            op2.Nombre = "Jose";
            op2.Edad = 40;
            op2.Puesto = "Contador";
            op2.Salario = 10000;

            op2.EmpleadoMuestra();
            Console.WriteLine("---------------");

            //herencia con metodos
            CEmpleado op3 = new CEmpleado();
            op3.ponerDatos("Susana", 25, "Programador", 15000);
            op3.EmpleadoMuestra();

            Console.ReadLine();
        }
    }
}
