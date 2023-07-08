using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    abstract class ClaseBase
    {
        public int q;//Atributo no abstracto
        public abstract void MostrarMensaje();//Metodo abstracto

        public virtual void DecirHola()//Metodo no abstracto
        {
            Console.WriteLine("Metodo no abstracto definido en la claseBase");
        }
    }
}
