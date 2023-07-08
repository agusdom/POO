using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal class Soldado
    {
        Arma armaa;

        internal Arma Armaa { get => armaa; set => armaa = value; }

        public void RecogerArma(Arma arma)
        {
            if(this.armaa == null)
            {
                this.armaa = arma;
                Console.WriteLine("Has agarrado un arma");
            }
            else
            {
                Console.WriteLine("Parece que el soldado ya está equipado con otra arma");
            }
        }

        public void DejarArma()
        {
            if (this.armaa != null)
            {
                this.armaa = null;
                Console.WriteLine("Has soltado el arma");
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene no tiene ningún arma en sus manos...");
            }
        }

        public void Disparar()
        {
            if (this.armaa != null)
            {
                this.armaa.Disparar();
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene no tiene ningún arma en sus manos...");
            }
        }

        public void VerArma()
        {
                if (this.armaa != null)
                {
                    Console.WriteLine(this.armaa.nombre);
                }
                else
                {
                Console.WriteLine("Parece que el soldado no tiene no tiene ningún arma en sus manos...");
                }
        }
    }
}
