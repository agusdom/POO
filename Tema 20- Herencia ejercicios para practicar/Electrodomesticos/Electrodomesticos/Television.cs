using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;


        public int Resolucion { get => resolucion; set => resolucion = value; }
        public bool SintonizadorTDT { get => sintonizadorTDT; set => sintonizadorTDT = value; }

        public Television()
        {
            Resolucion = 20;
            SintonizadorTDT = false;
        }

        public Television(float Precio,float Peso) : base(Precio, Peso)
        {
            Precio = precioBase;
            Peso = Peso;
        }

        public Television(float Precio, String Color, String ConsumoEnergetico, float Peso, int resolucion, bool sintonizadorTDT) : base(Precio, Color, ConsumoEnergetico, Peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT= sintonizadorTDT;
            Precio = precioBase;
            Color = Color;
            ConsumoEnergetico = ConsumoEnergetico;
            Peso = Peso;

        }

        public override float CalcularPrecioFinal()
        {
            base.CalcularPrecio();
            if(resolucion > 40)
            {
                precioBase += ((precioBase * 30)/100);
            }
            if(sintonizadorTDT == true)
            {
                precioBase += ((precioBase * 50) / 100);
            }
            return PrecioBase;
        }
    }

}
