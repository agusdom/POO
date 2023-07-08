using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero entero que represente al atributo LADO:");
            String entrada = Console.ReadLine();
            Cubo cubo = new Cubo(entrada);//Instanciamos un objeto de clase cubo.
            //cubo.Lado = 5;

            cubo.calcularArea();
            cubo.calcularVolumen();

            Console.WriteLine("Area del cubo = {0}, Volumen del cubo = {1}",cubo.Area,cubo.Volumen);  
            Console.ReadKey();
        }
    }
}
