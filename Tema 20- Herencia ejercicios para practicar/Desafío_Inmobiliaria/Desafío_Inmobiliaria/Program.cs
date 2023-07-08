using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Inmobiliaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locales local = new Locales("Belgrano 6454", 10, 60, 150000, 5);
            Console.WriteLine($"Este inmueble posee {local.antiguedad} años de antiguedad,{local.metrosCuadrados} m2 y {local.CantVentanales} ventanales, por lo que su precio final es:${local.CalcularPrecio()}");
            Pisos piso = new Pisos("Lucas Cordoba 769", 10, 60, 200000, 4);
            Console.WriteLine($"Este inmueble posee {piso.antiguedad} años de antiguedad,{piso.metrosCuadrados} m2 y {piso.CantPisos} pisos, por lo que su precio final es:${piso.CalcularPrecio()}");
            Console.ReadKey();
        }
    }
}
