using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composición
{
    internal class Mesa
    {
        private List<Pata> patas;
       internal List<Pata> Patas { get => patas; }

        public Mesa(int cantPatas) {
            patas = new List<Pata>();

            for (int i = 0; i < cantPatas; i++)
            {
                patas.Add(new Pata());
            }
        }

   
    internal class Pata
    {
        public String color = "Blanco";
    }
}
}