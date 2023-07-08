using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    internal class Point
    {
        //Atributos
        protected int x;//protected es siempre heredado por clases hijas
        protected int y;

        //Propiedades
        public int X { get => x; set => x = value; }//Tambien es heredado por clases hijas
        public int Y { get => y; set => y = value; }

        //Constructores
        //Metodos
        public virtual void mostrarMensaje()
        {
            Console.WriteLine("Metodo invocado desde la clase Point");
        }


    }
}
