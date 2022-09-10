using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_Casting_Type_cast_en_clase_y_tipos_numericos
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
        public override string ToString()
        {
            return string.Format("{0} cuesta {1} se vende en {2}", descripcion, precioCompra, precioVenta);
        }
    }
}
