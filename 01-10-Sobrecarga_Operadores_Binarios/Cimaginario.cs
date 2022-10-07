using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_10_Sobrecarga_Operadores_Binarios
{
    class Cimaginario
    {
        private double entero;
        private double imaginario;

        public Cimaginario(double opEntero, double opImaginario)
        {
            entero = opEntero;
            imaginario = opImaginario;
        }

        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginario { get { return imaginario; } set { imaginario = value; } }

        //para mostrar el numero imaginario
        public override string ToString()
        {
            if (imaginario < 0)
            {
                return string.Format("({0}   {1}i)", entero, imaginario);

            }
            else
            {
                return string.Format("({0} + {1}i)", entero, imaginario);
            }
        }

        //sobre carga de los operadores binarios
        //a= i1 + i2

        public static Cimaginario operator +(Cimaginario i1, Cimaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.entero + i2.entero;
            ri = i1.imaginario + i2.imaginario;

            Cimaginario temp = new Cimaginario(re, ri);
            return temp;
        }

        public static Cimaginario operator -(Cimaginario i1, Cimaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.entero - i2.entero;
            ri = i1.imaginario - i2.imaginario;

            Cimaginario temp = new Cimaginario(re, ri);
            return temp;
        }

        public static Cimaginario operator *(Cimaginario i1, Cimaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = (i1.entero * i2.entero) - (i1.imaginario * i2.imaginario);
            ri = (i1.imaginario * i2.imaginario) - (i1.imaginario * i2.imaginario);

            Cimaginario temp = new Cimaginario(re, ri);
            return temp;
        }
        public static Cimaginario operator /(Cimaginario i1, Cimaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = ((i1.entero * i2.entero) + (i1.entero * i2.entero))
                / ((i2.entero * i2.entero) + (i2.entero * i2.entero));

            ri = ((i1.entero * i2.entero) + (i1.entero * i2.entero))
                / ((i2.entero * i2.entero) + (i2.entero * i2.entero));

            Cimaginario temp = new Cimaginario(re, ri);
            return temp;
        }

        //sobre carga de operadores unuarios
        public static Cimaginario operator ++(Cimaginario i1)
        {
            Cimaginario temp = new Cimaginario(i1.entero + 1, i1.imaginario + 1);
            return temp;
        }
        public static Cimaginario operator --(Cimaginario i1)
        {
            Cimaginario temp = new Cimaginario(i1.entero - 1, i1.imaginario - 1);
            return temp;
        }

        //sobre carga del operador de igualda y desigualdad
        public override bool Equals(object obj)
        {
            //verificamos que sea del tipo correcto 
            if (obj is Cimaginario)
            {
                Cimaginario temp = (Cimaginario)obj;

                //comparamos por igualdad
                if (imaginario == temp.imaginario && entero == temp.entero)
                    return true;
            }
            return false;
        }

        public static bool operator ==(Cimaginario i1, Cimaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(Cimaginario i1, Cimaginario i2)
        {
            return !(i1.Equals(i2));
        }

        //sobrecarga de < y > necesitamos IComparable
        public double magnitud()
        {
            double m = 0;
            m = Math.Sqrt((entero * entero) + (imaginario * imaginario));
            return m;
        }

        public int CompareTo(object obj)
        {
            if (obj is Cimaginario)
            {
                Cimaginario temp = (Cimaginario)obj;

                if (magnitud() > temp.magnitud())
                    return 1;
                if (magnitud() < temp.magnitud())
                    return -1;
            }
            return 0;
        }

        public static bool operator <(Cimaginario i1, Cimaginario i2)
        {
            if (i1.CompareTo(i2) < 0)
                return true;
            else
                return false;
        }
        public static bool operator >(Cimaginario i1, Cimaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
                return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
