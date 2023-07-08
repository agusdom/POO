using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Y_Polimorfismo
{
    internal class Helicoptero : Vehiculo
    {
        public override void Estacionarse()//Implementación del método abstacto de la superclase
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("1) El piloto acomoda el helicoptero sobre estacionamiento.");
            Console.WriteLine("2) El piloto realiza maniobras de aterrizaje.");
            Console.WriteLine("3) El piloto apaga el motor.");
            Console.WriteLine($"4) El helicoptero {this.Nombre} se estaciono con exito.");
        }
    }
}
