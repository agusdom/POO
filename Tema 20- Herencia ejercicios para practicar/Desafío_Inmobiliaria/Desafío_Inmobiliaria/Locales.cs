using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Inmobiliaria
{
    internal class Locales : Inmueble
    {
        private int cantVentanales;

        public int CantVentanales { get => cantVentanales; set => cantVentanales = value; }
        public Locales(string direccion, int antiguedad, int metrosCuadrados, float precioBase,int cantVentanales) : base(direccion, antiguedad, metrosCuadrados, precioBase)
        {
            this.CantVentanales = cantVentanales;
        }

       

        public float CalcularPrecio()
        {
            float precioFinal = 0;
            float aumentoTamaño = 0;
            float precioVentanal = 0;
            float devaluacionXAntiguedad = base.CalcularPrecio();
           
            if (metrosCuadrados > 50)
            {
                aumentoTamaño = ((precioBase * 1) / 100);
          
            }
            if(CantVentanales <= 1)
            {
                precioVentanal = ((precioBase * 2) / 100) * -1;
                
            }
            else if (CantVentanales > 4)
            {
                precioVentanal = ((precioBase * 2) / 100);
               
            }
            precioFinal = precioBase - devaluacionXAntiguedad + aumentoTamaño + precioVentanal;
            return precioFinal;
        }
    }
}
