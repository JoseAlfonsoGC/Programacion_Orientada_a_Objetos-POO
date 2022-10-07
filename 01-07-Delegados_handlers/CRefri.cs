using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_07_Delegados_handlers
{
    class CRefri
    {
        //Ahora los delegados se declaran dentro de la clase
        public delegate void DReservasBajas(int opKilos);
        public delegate void DDescongelado(int opGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        //Aqui estan las variables que usaremos para invocar 
        private DReservasBajas delegReservas;
        private DDescongelado delegDescongelado;

        public CRefri(int opKilos, int opGrados)
        {
            //coloca los valores iniciales del refri
            kilosAlimentos = opKilos;
            grados = opGrados;
        }

        //estos metodos permiten referenciar las variables
        public void AdicionaMetdoReservas(DReservasBajas opMetodo)
        {
            delegReservas = opMetodo;
        }
        public void AdicionaMetodoDescongelado(DDescongelado opMetodo)
        {
            delegDescongelado = opMetodo;
        }

        //propiedades necesarias
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int opConsumo)
        {
            //Actualizamos los kilos del refri
            kilosAlimentos -= opConsumo;

            //subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados ", kilosAlimentos, grados);

            //hay que verificar si se cumple la condicion para 
            //invocar los handlers del evento

            //esta es la condicion del evento para los kilos 
            if (kilosAlimentos < 10)
            {
                //invocamos el metodo
                delegReservas(kilosAlimentos);

            }

            //esta el condicion del evento para la temperatura
            if (grados > 0)
            {
                //invocamos el metodo
                delegDescongelado(grados);
            }
        }
    }
}
