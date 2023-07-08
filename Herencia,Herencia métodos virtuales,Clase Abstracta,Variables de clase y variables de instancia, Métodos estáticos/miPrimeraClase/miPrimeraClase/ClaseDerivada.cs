using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    class ClaseDerivada : ClaseBase
    {
        public override void MostrarMensaje()
        {
            Console.WriteLine("Metodo lanzado desde la clase claseDerivada");
        }

        public override void DecirHola()
        {
            Console.WriteLine("Metodo no abstracto redefinido en la claseDerivada"); ;
        }
    }
}
