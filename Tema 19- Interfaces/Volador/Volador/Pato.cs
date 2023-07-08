using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    internal class Pato : Animal, Volador
    {
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un pato...¡Cuak!");
        }
    }
}