using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoDeCarreras
{
    internal class Maratonista : Persona, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El maratonista comienza a correr......");
        }
    }
}
