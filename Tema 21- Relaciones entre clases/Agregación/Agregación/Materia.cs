using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregación
{
    internal class Materia
    {
        private String nombre;
        private List<Tema> temas;
        public String Nombre { get => nombre; set => nombre = value; }
        internal List<Tema> Temas { get => temas;}

        public Materia(String nom) { 
            nombre = nom;
            temas = new List<Tema>();
        }

        public void AgregarTema(Tema t) {
            Temas.Add(t);
        }
    }
}
