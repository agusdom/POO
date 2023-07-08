using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoDeCarreras
{
    internal class VideoJuegoDeCarreras
    {
        List<Icorredor> corredores = new List<Icorredor>();
        public VideoJuegoDeCarreras()
        {
            Perro perro = new Perro();
            corredores.Add(perro);

            Caballo caballo = new Caballo();
            corredores.Add(caballo);

            Ferrari ferrari = new Ferrari();
            corredores.Add(ferrari);

            Maratonista maratonista = new Maratonista();
            corredores.Add(maratonista);

            Console.ReadKey();
        }

        public void IniciarCarrera()
        {
            foreach (Icorredor c in corredores)
            {
                c.Correr();
            }
        }
    }
}
