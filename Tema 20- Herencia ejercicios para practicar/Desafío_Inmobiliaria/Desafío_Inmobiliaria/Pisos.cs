using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Inmobiliaria
{
    internal class Pisos : Inmueble
    {
        private int cantPisos;

        public int CantPisos { get => cantPisos; set => cantPisos = value; }

        public Pisos(string direccion, int antiguedad, int metrosCuadrados, float precioBase,int cantPisos) : base(direccion,antiguedad,metrosCuadrados,precioBase)
        {   
            this.CantPisos = cantPisos;
        }

       

        public float CalcularPrecio()
        {
            float precioFinal = 0;
            float devaluacionXAntiguedad = base.CalcularPrecio();
            float aumentoCantPisos = 0;
            if(CantPisos >= 3)
            {
                aumentoCantPisos = ((precioBase * 3) / 100);
            }
            precioFinal = precioBase + aumentoCantPisos - devaluacionXAntiguedad;
            return precioFinal;
        }
    }
}
