using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Delegados_multiples_handlers
{
    delegate void DReservasBajas(int opKilos);
    delegate void DDescongelado(int opGrados);
    class CRefri
    {
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
        //Estos metodos permitiran referenciar las variables 
        //hacemos multicasting
        public void AdicionaMetodoReservas(DReservasBajas opMetodo)
        {
            delegReservas += opMetodo;
        }
        public void EliminaMetodoReservas(DReservasBajas opMetodo)
        {
            delegReservas -= opMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado opMetodo)
        {
            delegDescongelado += opMetodo;
        }

        //propiedades necesarias
        public int kilos { get { return kilosAlimentos; } set { kilosAlimentos = value; } }
        public int Grados { get { return grados; } set { grados = value; } }

        public void Trabajo(int opConsumo)
        {
            //Actualizamos los kilos del refri
            kilosAlimentos -= opConsumo;

            //subimos la temperatura
            grados += 1;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //hay que verificar si se cumple la condicion para invocar los handlers del evento

            //esta es la condicion del evento para los kilos
            if (kilosAlimentos < 10)
            {
                //Invocar el metodo
                delegReservas(kilosAlimentos);
            }

            //esta es la condicion del evento para la temperatura
            if (grados > 0)
            {
                //invocamos el metodo
                delegDescongelado(grados);
            }

        }
    }
}
