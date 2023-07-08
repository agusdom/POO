using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    internal class Impresora
    {
        public void Imprimir(Documento documento)//Dependecia
        {
            Console.WriteLine(documento.Texto);
        }
    }
}
