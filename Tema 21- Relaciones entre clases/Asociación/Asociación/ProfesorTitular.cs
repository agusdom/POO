using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    internal class ProfesorTitular
    {
        private String nombre;
        private List<Materia> materias = new List<Materia>();

        public String Nombre { get => nombre; }
        internal List<Materia> Materias { get => materias;}

        //Constructor
        public ProfesorTitular(String nom)
        {
            nombre = nom;
        }

        //Metodos

        public void AgregarMateria(Materia materia)
        {
            Materias.Add(materia);
        }


    }
}
