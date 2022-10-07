using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_Callback_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos al refri
            CRefri refri = new CRefri(50, -20);

            Random rnd = new Random();

            //creamos el sink
            //sink1 tiene el codigo que se ejecutara cuendo suceda el evento
            CRefriSink sinkUno = new CRefriSink();

            //Adicionamos el sink al refri
            refri.AgregarSinks(sinkUno);

            //Erefri hace su trabajo
            while (refri.kilos > 0)
            {
                //el refri trabaja y le sacamos kilos al azar
                refri.Trabajar(rnd.Next(1, 5));
            }
        }
    }
}
