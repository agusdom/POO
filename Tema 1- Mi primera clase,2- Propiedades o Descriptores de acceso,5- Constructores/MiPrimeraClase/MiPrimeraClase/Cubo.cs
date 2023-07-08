using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraClase
{
    class Cubo
    {
        //atributos
        private int lado;
        private int area;
        private int volumen;

        //Constructores
        public Cubo()
        {
            lado = 5;
            area = 0;
            volumen = 0;
        }

        public Cubo(string lado)
        {
            int numero = 0;
            try
            {
                numero = int.Parse(lado);
            }
            catch (Exception e)
            {

            }
            this.lado = numero;
        }

        public int Lado { get => lado; set => lado = value; }
        public int Area { get => area;}
        public int Volumen { get => volumen; }



        //métodos
        public void calcularArea()
        {
            area = (Lado * Lado) * 6;
        }

        public void calcularVolumen()
        {
            volumen = Lado * Lado * Lado;
        }
    }
}
