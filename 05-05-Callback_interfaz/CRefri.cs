using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_Callback_interfaz
{
    class CRefri
    {
        //los sinks con los ques se comunicara el refri
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimentos = 0;
        private int grados = 0;

        public CRefri(int opKilos, int opGrados)
        {
            //coloca los valores iniciales del refri
            kilosAlimentos = opKilos;
            grados = opGrados;
        }
        //con este metodo adicionamos un sink
        public void AgregarSinks(IEventosRefri opSink)
        {
            if (opSink != null)
            {
                listaSinks.Add(opSink);
            }
        }
        //con este metodo eliminamos un  sink
        public void EliminarSink(IEventosRefri opSink)
        {
            if (listaSinks.Contains(opSink))
            {
                listaSinks.Remove(opSink);
            }
        }

        //propiedades necesarias
        public int kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int opConsumo)
        {
            //Actualizamos los kilos del refri
            kilosAlimentos -= opConsumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, Grados);

            //Hay que verificar si se cumple la condicin para invocar los handlers del evento
            //esta e sla condicion del evento
            if (grados >= 0)
            {
                //invocamos a los handlers de cada sink
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }
        }
    }
}
