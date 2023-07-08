using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Lavadora : Electrodomestico
    {
        private int carga;

        public int Cargar { get => carga; }

        public Lavadora() 
        {
            carga = 5;
        }

        public Lavadora(float precio, float peso) : base(precio, peso)
        {
            precio = precioBase;
            peso = peso;
        }

        public Lavadora(float Precio, String Color, String ConsumoEnergetico, float Peso, int carga) : base(Precio, Color, ConsumoEnergetico, Peso)
        {
            this.carga = carga;
            Precio = precioBase;
            Color = Color;
            ConsumoEnergetico = ConsumoEnergetico;
            Peso = Peso;

        }

        public override float CalcularPrecioFinal()
        {
            base.CalcularPrecio();
           if (Cargar > 30)
            {
                this.precioBase =+ 50;
            }
           return this.precioBase;
        }
      }
}

