using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //un programa orientado a objetos es basicamente una colección de objetos. 

            /*el objeto son los elementos que componen a un sistema, se definen por: atributos, acceso, comportamiento, mensajes.
            
            -un objeto guarda datos en su interior, estos datos se llaman atributos
            
            -el tipo de acceso: públic, privado, protegido. permite o niega la visibilidad del objeto. 
                *public -el exterior tiene acceso.
                *private -solo el mismo objeto puede acceder.
                *protegido -unicamente dentro de la cadena de herencia se tiene acceso.
            
            -comportamiento del objeto representa lo que el objeto puede hacer:
                *es una accion que lleva a cabo el objeto cuando recibe un mensaje o cuando cambia su estado interno, los comportamientos se colocan en metodos.
            -mensajes
                *son el mecanismo de comunicación.
                *Esto se logra cuando un objeto invoca un método, para lo cual necesitamos conocer.
                    +nombre del metodo.
                    +parametros a pasar al método.
                    +tipo de retorno del metodo.
             
             */
            //en poo
            //no hay objetos globales
            //lo que existe dentro de un objeto no es compartido entre otros objetos
            CCalcular op = new CCalcular();

            op.a = 18;
            op.b = 53;

            op.Suma();

            op.Muestra();

            Console.ReadLine();
        }
    }
}
