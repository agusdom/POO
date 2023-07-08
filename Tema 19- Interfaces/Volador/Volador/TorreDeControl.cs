using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    internal class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();

        public void vuelenTodos()
        {
            foreach(Volador v in voladores)
            {
                v.Volador();
            }
        }

        public void agregarVolador(Volador unVolador)
        {
            voladores.Add(unVolador);
        }
    }
}
