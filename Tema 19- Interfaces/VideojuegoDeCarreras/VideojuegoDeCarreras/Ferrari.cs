﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoDeCarreras
{
    internal class Ferrari : Vehiculo, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("La ferrari comienza a correr......");
        }
    }
}
