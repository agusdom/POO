using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregación
{
    internal class Tema
    {
        private String nombre;
        private Materia materia;

        public String Nombre { get => nombre; set => nombre = value; }
        internal Materia Materia { get => materia; set => materia = value; }

        public Tema(String nom)
        {
            nombre = nom;
        }
    }
}
