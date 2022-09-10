using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_clases_abstractas_e_interfaces
{
    class CProductoDetenido:CProducto
    {
        protected double multa;
        protected double impuesto;

        public CProductoDetenido(string descripcion, double precioCompra, double impuesto, double multa)
            : base(descripcion, precioCompra)
        {
            this.impuesto = impuesto;
            this.multa = multa;
        }
        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de importado con multa");
            precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
        }
        //si no se implementar el miembro abstracto de la clase padre marcara un error
        public override void MuestraVenta()
        {
            Console.WriteLine("El producto en aduana {0} tiene un costo de  {1} ", descripcion, precioVenta);
        }
    }
}
