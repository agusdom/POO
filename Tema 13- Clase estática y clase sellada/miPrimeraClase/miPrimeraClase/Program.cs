﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 15;
            bool resultado = Utiles.validarLongitud(numero);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
