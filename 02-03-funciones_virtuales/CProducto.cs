using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_funciones_virtuales
{
    class CProducto
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string descripcion, double precioCompra)
        {
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            precioVenta = 0.0;
        }
        public virtual void CalculaPrecio()//el metodo con modificador virtual es ocupado en la cadena de herencia para que cada clase implemente su propio metodo con el mismo nombre
        {                                   //en caso de que la clase hija no quiera modificar este metodo se ocupa el metodo de la clase padre.
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }
        public void MuestraVenta()
        {

            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }
    }
}
