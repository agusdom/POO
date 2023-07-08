using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    internal class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach(Imprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
