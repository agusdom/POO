using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract  class Electrodomestico
    {
        protected float precioBase;
        protected String color;
        protected String consumoEnergetico;
        protected float peso;


        public float PrecioBase { get => precioBase;}
        public String Color { get => color;}
        public String ConsumoEnergetico { get => consumoEnergetico;}
        public float Peso { get => peso;}

        public Electrodomestico()
        {
        precioBase = 100;
        color = "Blanco";
        consumoEnergetico = "F";
        peso = 5;
    }

        public Electrodomestico(float Precio,float Peso) 
        {
            peso = Peso;
            color = "Blanco";
            consumoEnergetico = "F";
            precioBase = Precio;
        }

        public Electrodomestico(float Precio,String Color,String ConsumoEnergetico,float Peso) {
            precioBase = Precio;
            ComprobarColor(Color);
            ComprobarConsumoEnergetico(ConsumoEnergetico);

            peso = Peso;
        }

        private void ComprobarConsumoEnergetico(String letra)
        {
            if(!letra.Equals("A") || !letra.Equals("B") || !letra.Equals("C") || !letra.Equals("D") || !letra.Equals("E") || !letra.Equals("F"))
            {
                consumoEnergetico = "F";

            }
        }

        private void ComprobarColor(String Color)
        {
            if (!Color.Equals("Blanco") || !Color.Equals("Rojo") || !Color.Equals("Negro") || !Color.Equals("Azul") || !Color.Equals("Gris"))
            {
                color = "Blanco";
            }
        }

        protected void CalcularPrecio()
        {
            if (ConsumoEnergetico.Equals("A"))
            {
                precioBase += 100;
            }
            else if(ConsumoEnergetico.Equals("B"))
            {
                precioBase += 80;
            }
            else if (ConsumoEnergetico.Equals("C"))
            {
                precioBase += 60;
            }
            else if (ConsumoEnergetico.Equals("D"))
            {
                precioBase += 50;
            }
            else if (ConsumoEnergetico.Equals("E"))
            {
                precioBase += 30;
            }
            else if (ConsumoEnergetico.Equals("F"))
            {
                precioBase += 10;
            }
            if(Peso>=0 && Peso <= 19)
            {
                precioBase += 10;
            }else if (Peso >= 20 && Peso <= 49)
            {
                precioBase += 50;
            }
            else if (Peso >= 50 && Peso <= 79)
            {
                precioBase += 80;
            }
            else if (Peso >= 80)
            {
                precioBase += 100;
            }
        }

        public abstract float CalcularPrecioFinal();
    }
}
