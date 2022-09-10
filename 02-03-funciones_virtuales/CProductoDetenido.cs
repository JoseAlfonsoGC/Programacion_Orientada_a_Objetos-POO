using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_funciones_virtuales
{
    class CProductoDetenido:CProductoImportado
    {
        private double multa;

        public CProductoDetenido(string descripcion, double precioCompra, double impuesto, double multa)
            : base(descripcion, precioCompra, impuesto)
        {
            this.multa = multa;
        }
        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de importado con multa");
            precioVenta = ((precioCompra * (1 + impuesto)) * 1.39) + multa;
        }
    }
}
