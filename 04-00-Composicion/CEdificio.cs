using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_Composicion
{
    class CEdificio
    {
        private string direccion;
        private int canDepartamentos;
        private int depRentados;

        public CEdificio(string direccion, int canDepartamentos, int depRentados)
        {
            this.direccion = direccion;
            this.canDepartamentos = canDepartamentos;
            this.depRentados = depRentados;
        }
        public void Muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} deptos, {2} rentados", direccion, canDepartamentos, depRentados);
        }
    }
}
