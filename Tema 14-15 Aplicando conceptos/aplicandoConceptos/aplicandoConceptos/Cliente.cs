using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicandoConceptos
{
    internal class Cliente
    {
        //Atributos
        private String nombre;
        private String apellido;
        private String dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        //Constructor
        public Cliente(String name,String lastName,String dni) {
            Nombre = name;
            Apellido = lastName;
            Dni = dni;
        }

    }
}
