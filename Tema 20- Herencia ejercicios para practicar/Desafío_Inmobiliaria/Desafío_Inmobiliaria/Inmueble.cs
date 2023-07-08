using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Inmobiliaria
{
    abstract class Inmueble
    {
        public String direccion;
        public int antiguedad;
        public int metrosCuadrados;
        public float precioBase;

        public Inmueble(string direccion, int antiguedad, int metrosCuadrados, float precioBase)
        {
            this.direccion = direccion;
            this.antiguedad = antiguedad;
            this.metrosCuadrados = metrosCuadrados;
            this.precioBase = precioBase;
        }


        public float CalcularPrecio()
        {
            float reduccionAnt = 0;
            if (antiguedad < 15)
            {
                reduccionAnt = ((precioBase * 1) / 100);
            }
            else if (antiguedad > 15)
            {
                reduccionAnt = ((precioBase * 2) / 100);
            }
            return reduccionAnt;
        }
    }
}
