using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    internal class Boing747 : Aviones, Volador
    {
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un avion...");
        }
    }
}
