using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_00_clase_constructor_metodo_s
{
    class Ccalcula
    {
        //clase
        /*
          es un plano a partir del cual el objeto es construido
          Indica que atributos y como funcionan los metodos que tendra el objeto
          muchos objetos pueden ser construidos a partir de una misma clase
          tambien pódemos pensar en la clase como un tipo de dato de alto nivel o definido por el programador
        
         * nombre de la clase 
            -identifica la clase, debe de ser descriptivo, provee informacion de que hace la clase y como interactúa con el sistema
            -el lenguaje puede tener reglas para el nombre de la clase
         
         * instancia
            -el objeto tambien se le conoce como instancia
            -el crear un objeto a partir de una clase se conoce como instancia 


          *en un diagrama UML una clase se visualiza de la siguiente manera
            //nivel 1 nombre 
            //nivel 2 atributos
            //nivel 3 comportamientos
            //ejemplo
            // si es privado (-) si es publico +
            //si en los procesos se regresara un valor se colocaria (:)
            _________________
            |   Empleado    | 
            |---------------|
            |-nombre:string |
            |-edad  :int    |
            |-puesto:string |
            |-salari:string |
            |---------------|
            |+trabajar()    |
            |+setPuesto()   |
            |+setHonorario()|
            |+getHonorario()|
            |+comer()       |
            |+verificHora() |
            |+calclImpuesto(|
            -----------------
         * Constructor
         * 
            -se invoca cuando el objeto es construido
            -tiene el mismo nombre de la clase
            -no tiene tipo
            -acceso público
            -podemos colocar uno propio o el sistema usa uno de default
            -es el lugar para inicializar los valore que tienen los atributos y que el objeto quede en un estado estable o conocido
        */
        double x, y;
        double r;
        public Ccalcula(double x, double y)//si se declaran parametros en el constructor se tiene que enviar cuando se cree el objeto en Main
        {
            this.x = x;
            this.y = y;
        }
        /*

        * Metodo
        *
        -Bloque de codigo diferenciado por un nombre, puede ser llamado con el mismo dependiendo de donde sea requerido en el sistema y el modificador de acceso, puede que existan diferentes versiones de un mismo metodo. 
        -mutator
         permite alterar el estado interno del objeto
         */
        public void Suma()
        {
            r = x + y;
        }
        public void Muestra()
        {
            Console.WriteLine("x={0} + y={1}, r={2}", x.ToString(), y.ToString(), r.ToString());
        }
    }

}
