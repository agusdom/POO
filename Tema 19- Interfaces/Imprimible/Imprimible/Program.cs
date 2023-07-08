using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Contrato contrato = new Contrato();
            impresora.AgregarImprimible(contrato);
            Documento documento = new Documento();
            impresora.AgregarImprimible(documento);
            Foto foto = new Foto();
            impresora.AgregarImprimible(foto);
            impresora.ImprimirTodo();
            Console.ReadKey();

        }
    }
}
