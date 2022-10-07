using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_10_Sobrecarga_Operadores_Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cimaginario im1 = new Cimaginario(1, 2);
            //Cimaginario im2 = new Cimaginario(3, 4);
            //Cimaginario imr;


            //sobre carga de operadores binarios

            ////hacemos la suma
            ///
            /// //im1++;
            //Console.WriteLine(im1);
            //Console.WriteLine("------------");
            //Console.WriteLine(im1);

            //im1++;
            //Console.WriteLine(im1);
            //Console.WriteLine("------------");
            //Console.WriteLine(im1);

            //im1++;
            //Console.WriteLine(im1);
            //Console.WriteLine("------------");
            //imr = im1 + im2;
            //Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);

            ////hacemos la resta
            //imr = im1 - im2;
            //Console.WriteLine("{0} - {1} = {2}", im1, im2, imr);

            ////hacemos la multiplicacion
            //imr = im1 * im2;
            //Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            ////hacemos la division
            //imr = im1 / im2;
            //Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);

            //Console.WriteLine("-----------------------------------");

            ////sobre carga de operadores unuarios

            //Console.WriteLine(im1);
            //im1++;
            //Console.WriteLine(im1);
            //Console.WriteLine("------------");

            //Console.WriteLine(im1);
            //im1--;
            //Console.WriteLine(im1);
            //Console.WriteLine("------------");
            //Console.WriteLine(im1);

            //sobre carga de operadores de igualdad y desigualdad (unarios)

            Cimaginario im1 = new Cimaginario(1, 2);
            Cimaginario im2 = new Cimaginario(3, 4);
            Cimaginario im3 = new Cimaginario(5, 7);
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
