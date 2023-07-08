using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torreDeControl = new TorreDeControl();
            Pato pato = new Pato();
            torreDeControl.agregarVolador(pato);
            Boing747 boing747 = new Boing747();
            torreDeControl.agregarVolador(boing747);
            Superman superman = new Superman();
            torreDeControl.agregarVolador(superman);
            torreDeControl.vuelenTodos();
            Console.ReadKey();
        }
    }
}
