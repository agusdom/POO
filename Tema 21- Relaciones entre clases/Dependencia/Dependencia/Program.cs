using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento documento = new Documento("Hola,soy un documento PDF.....");
            Impresora impresora = new Impresora();

            impresora.Imprimir(documento);
            Console.ReadKey();
        }
    }
}
