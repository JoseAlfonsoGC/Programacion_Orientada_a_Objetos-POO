using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_Casting_Type_cast_en_clase_y_tipos_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo de casting

            //podemos hacer casting de una clase en la cadena de herencia 
            //el casting permite que una clase se implemente como otra, se lleva acabo de lo más especifico a lo mas general
            //ejemplo
            CProducto p1 = new CProductoImportado("Tele", 2500, 0.15);//CProductoImportado es un CProducto

            p1.CalculaPrecio();
            Console.WriteLine(p1);
            //no podemos invocar lo que no es comun al padre
            //p1.Mensaje();
            //pero si se quiere hacer uso de los metodos no comunes, se lleva acabo un casting
            ((CProductoImportado)p1).Mensaje();

            Console.WriteLine("----------");
            //CProducto es un object

            object p2 = new CProducto("Radio", 300);

            ((CProducto)p2).CalculaPrecio();//Type cast pra poder decir que p2 es un CProducto
            Console.WriteLine(((CProducto)p2));//Type cast para imprimir

            Console.WriteLine("-------------");

            //object no es un CProducto
            //CProducto p3 = new object();//anseguida da un error
            Console.WriteLine("-------------------Detecta-----------------");
            CProducto p4 = new CProducto("Balon", 250.50);

            Detecta(p1);
            Detecta((CProducto)p2);
            Detecta(p4);

            Console.WriteLine("-----");

            //casting numerico
            int a = 57;
            float b = 5.67f;
            double c = 123.456;
            byte x = 5;

            //De un tipo menor a uno mayor no hace falta poner explicitamente el casting
            a = x;
            Console.WriteLine(a);

            double y = b;
            Console.WriteLine(y);

            //De un tipo mayor a menor 
            //b=c;
            b = (float)c;
            Console.WriteLine(b);

            Console.ReadLine();
        }
        public static void Detecta(CProducto producto)
        {
            if (producto is CProducto)
            {
                Console.WriteLine("-- Es CProducto");
                producto.CalculaPrecio();
                Console.WriteLine(producto);
            }
            if (producto is CProductoImportado)
            {
                Console.WriteLine("-- Es CProductoImportado");
                producto.CalculaPrecio();
                ((CProductoImportado)producto).Mensaje();
                Console.WriteLine(producto);
            }
        }
    }
}
    
