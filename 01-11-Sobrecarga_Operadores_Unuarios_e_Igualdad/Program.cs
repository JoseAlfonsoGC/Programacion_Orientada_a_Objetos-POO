using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_11_Sobrecarga_Operadores_Unuarios_e_Igualdad
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario im3 = new CImaginario(5, 7);
            if (im1 == im3)
                Console.WriteLine("Son iguales");

            if (im2 != im1)
                Console.WriteLine("Son diferentes");

            if (im1 < im3)
                Console.WriteLine("im1 es menor");
            if (im2 > im1)
                Console.WriteLine("im2 es mayor");
        }
    }
}
