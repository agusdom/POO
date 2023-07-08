using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    internal class Point3D : Point
    {
       
           private int z;

        public int Z { get => z; set => z = value; }

        public override void mostrarMensaje()
        {
            Console.WriteLine("Metodo invocado desde la clase Point3D");
        }

    }
}
