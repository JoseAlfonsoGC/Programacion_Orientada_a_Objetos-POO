using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_Composicion_Ejemplo_01
{
    class CAulas
    {
        private string nombreAula;
        private int cantidadAlumnos;

        public CAulas(string nombreAula, int cantidadAlumnos)
        {
            this.nombreAula = nombreAula;
            this.cantidadAlumnos = cantidadAlumnos;
        }
        public override string ToString()
        {
            string mensaje = string.Format("El aula {0}, tiene {1} alumno", nombreAula, cantidadAlumnos);
            return mensaje;
        }
    }
}
