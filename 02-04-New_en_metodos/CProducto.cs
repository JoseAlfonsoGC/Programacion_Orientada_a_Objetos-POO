using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04_New_en_metodos
{
    class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string descripcion, double precioCompra)
        {
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            precioVenta = 0.0;
        }
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }
        //en la clase de producto importado es donde se lleva acabo el ejemplo del uso de new
        public void MuestraVenta()
        {

            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }
    }
}
