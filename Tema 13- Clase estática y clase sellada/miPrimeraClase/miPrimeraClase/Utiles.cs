using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    static class Utiles
    {
        static int numeroX = 2;
        public static bool validarLongitud(int numero)
        {
            if (numero < numeroX)
            {
                return true;
            }
            return false;
        }
    }
}
