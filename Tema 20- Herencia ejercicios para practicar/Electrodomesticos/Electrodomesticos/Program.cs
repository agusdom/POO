using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> list = new List<Electrodomestico>();
            Television t = new Television();
            Television t2 = new Television(500, 200);
            Television t3 = new Television(100, 80);
            Lavadora l = new Lavadora();
            Lavadora l2 = new Lavadora(60,10);
            Lavadora l3 = new Lavadora(150,100);
            list.Add(t);
            list.Add(t2);
            list.Add(t3);
            list.Add(l);
            list.Add(l2);
            list.Add(l3);
            float precioFTE = 0;
            float precioFT = 0;
            float precioFL = 0;
            foreach (Electrodomestico e in list)
            {
                if (e.GetType().Name == "Television")
                {
                    precioFT = precioFT + e.CalcularPrecioFinal();
                }
                else if (e.GetType().Name == "Lavadora")
                {
                    precioFL = precioFL + e.CalcularPrecioFinal();
                }

                precioFTE = precioFT + precioFL;

            }
            Console.WriteLine("Precio final de todos los electrodomesticos $" +precioFTE);
            Console.WriteLine("Precio final de todos los Televisores $" + precioFT);
            Console.WriteLine("Precio final de todos las lavadoras $" + precioFL);
            Console.ReadKey();
        }
    }
}
