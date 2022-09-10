using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Metodo_privado_y_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            CComputadora op1 = new CComputadora();
            CComputadora op2 = new CComputadora("i7", 8, 670);
            
            op1.TipoCambio = 15.70;

            op1.MuestraDolares();
            op1.MuestraPesos();
            Console.WriteLine("-------");

            op2.TipoCambio = 15.70;//con static podemos evita declarar po segunda vez

            op2.MuestraDolares();
            op2.MuestraPesos();
            Console.WriteLine("-------");

            Console.ReadLine();
        }
    }
}
