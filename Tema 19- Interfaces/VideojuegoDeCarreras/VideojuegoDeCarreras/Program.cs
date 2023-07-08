using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoDeCarreras
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            VideoJuegoDeCarreras partida = new VideoJuegoDeCarreras();
            partida.IniciarCarrera();
            Console.ReadKey();
        }
    }
}
