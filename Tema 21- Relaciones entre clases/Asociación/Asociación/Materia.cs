using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    internal class Materia
    {
        //Atributos
        private String nombre;
        //private ProfesorTitular profesor;

        public String Nombre { get => nombre; }
        //internal ProfesorTitular Profesor { get => profesor; set => profesor = value; }

        //Constructor
        public Materia(String nom)
        {
            nombre = nom;
        }

    }
}
