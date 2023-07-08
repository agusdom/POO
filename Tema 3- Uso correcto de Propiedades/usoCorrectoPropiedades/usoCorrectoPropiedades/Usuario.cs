using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoCorrectoPropiedades
{
    internal class Usuario
    {
        private String nombre;
        private String apellido;
        private String dni;
        private String email;
        private String direccion;

        //Propiedades
        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public string Dni { get => dni;}
        public string Email { get => email;}
        public string Direccion { get => direccion; set => direccion = value; }

        public Usuario(String nom,String ape,String dni,String email,String dire = "")
        {
            nombre = nom;
            apellido = ape;
            this.dni = dni; 
            this.email = email;
            direccion = dire;

        }
    }
}
