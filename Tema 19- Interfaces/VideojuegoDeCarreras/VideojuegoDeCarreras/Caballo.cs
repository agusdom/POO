﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoDeCarreras
{
    internal class Caballo: Animal, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El caballo comienza a correr......");
        }
    }
}
