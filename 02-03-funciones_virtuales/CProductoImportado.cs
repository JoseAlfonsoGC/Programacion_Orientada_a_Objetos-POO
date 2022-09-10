using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_funciones_virtuales
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;
        public CProductoImportado(string descripcion, double precioCompra, double impuesto)
            : base(descripcion, precioCompra)
        {
            this.impuesto = impuesto;
        }
        //cuando se ocupa "sealed" en un metodo con override,
        /// <summary>
        /// posteriores clases hijas no podran hacer uso del metodo 
        /// como si de un sellado se tratara
        /// </summary>
        public override void CalculaPrecio()//para ocupar un metodo virtual en otra clase se tiene que colocar override despues del public en el metodo requerido
        {
            Console.WriteLine("Calcula precio de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        //public new void MuestraVenta()
        //{
        //    Console.WriteLine("El gran producto {0} se vende em $ {1}!!!!!", descripcion, precioVenta);
        //}
    }
}
