using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal abstract class Arma
    {
        public String nombre;

        protected string Nombre { get => nombre;}

        public abstract void Disparar();
    }
}
