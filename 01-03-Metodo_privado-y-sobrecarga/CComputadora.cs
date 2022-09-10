using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Metodo_privado_y_sobrecarga
{
    class CComputadora
    {
        private double tipoCambio;

        private string procesador;
        private int memoria;
        private double costo;
        private double cambioMoneda;

        //sobre carga de constructores 2 o mas metodos pueden tener el mismo nombre, es posible solo que con una diferencia en los parametros que reciben los metodos  
        public CComputadora()
        {
            procesador = "i3";
            memoria = 12;
            costo = 350;
        }
        public CComputadora(string procesador, int memoria, double costo)
        {
            this.procesador = procesador;
            this.memoria = memoria;
            this.costo = costo;
        }
        public double TipoCambio { get { return tipoCambio; } set { tipoCambio = value; } }

        //sobre carga de metodos: 2 o mas metodos pueden tener el mismo nombre, es posible solo que con una diferencia en los parametros que reciben los metodos  
        private void precioEnPesos(object fechaSistema, double precio)//el precio de una moneda puede ser modificado en el tiempo 
        {
           
        }
        //metodo privado: solo puede ser usado dentro de la clase, en ellos podemos hacer operaciones no visibles al exterior
        private void precioEnPesos()
        {
            cambioMoneda = costo * tipoCambio;
        }
        public void MuestraDolares()
        {
            Console.WriteLine("Procesador: {0}, memoria:{1}", procesador, memoria);
            Console.WriteLine("Costo $USD:{0}", costo);
        }
        public void MuestraPesos()
        {
            precioEnPesos();
            Console.WriteLine("Procesador: {0}, memoria:{1}", procesador, memoria);
            Console.WriteLine("Costo $:{0}, TC:{1}", cambioMoneda, tipoCambio);
        }
    }
}
