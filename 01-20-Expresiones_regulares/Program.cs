using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_20_Expresiones_regulares
{
    class Program
    {
        static void Main(string[] args)
        {//metodo 1

            //busqueda de espresion en un texto
            string texto = "La casa del casamentero";
            string exp = "casa";

            MatchCollection encontrado = Regex.Matches(texto, exp); //uso de matches

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("------------------");

            //metodo 2

            //busqueda de una palabra especifica (ojo si esta al final)
            texto = "El estudiante es un casanova en la escuela";
            exp = " casa ";

            Regex expReg = new Regex(exp); //uso de regex

            encontrado = expReg.Matches(texto);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("--------------------");

            //uso de "." significualquier caracter
            //cabal, campeon, academico

            texto = "Saludos al mas cabal";
            exp = " ca.";

            MatchesExp(texto, exp);

            //uso de clases de caracteres, se usa [] para contener los caracteres
            //Nico. Necio, Naco
            texto = "Hola Nico";
            exp = "N[ie]c";

            MatchesExp(texto, exp);

            //un rango 
            //Nico, Neco, Noco, Ndco, Nzco
            texto = "Hola Nico";
            exp = "N[a-u]c";

            MatchesExp(texto, exp);

            //uso del complemento
            //Noco, Nico
            texto = "Hola Noco";
            exp = "N[^ie]c";

            //verificamos si tiene la exprecion despues de n carter
            texto = "De youtube Nicosiored es mi canal favorito";
            exp = "N[ie]c";
            expReg = new Regex(exp);
            if (expReg.IsMatch(texto, 5))
                Console.WriteLine("Si tiene");
            else
                Console.WriteLine("No tiene");
            Console.WriteLine("----------------------------------");

            //para saber si una cadena finaliza con una exprecion
            texto = "De youtube Nicosiored es mi canal favorito";
            exp = "N[ie]c$";
            MatchesExp(texto, exp);

            //Elemento opcional
            //Nico, Nilo, Nio
            texto = "HOla Nico";
            exp = "N[ie]c?o";
            MatchesExp(texto, exp);

            //cuantificador
            //busca que existan n de esos elementos
            texto = "HOla 25 Nico";
            exp = "[0-9]{2}";
            MatchesExp(texto, exp);

            //Alternaciones
            texto = "yo se programar en c";
            exp = "(c|java|python)";
            MatchesExp(texto, exp);

            //split
            texto = "Este es un tes de separacion, divicion";
            exp = ",";

            string[] cadena = Regex.Split(texto, exp);

            foreach (string c in cadena)
                Console.WriteLine(c);
            Console.WriteLine("------------------------");

            //reemplazar
            texto = "Yo hablo ingles y no soy ingles";
            expReg = new Regex("ingles");

            string reemplazo = "Español";

            string resultado = expReg.Replace(texto, reemplazo);

            Console.WriteLine(reemplazo);
        }
        public static void MatchesExp(string opTexto, string opExp)
        {
            MatchCollection encontrado = Regex.Matches(opTexto, opExp);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("------------------");
        }
    }
}
