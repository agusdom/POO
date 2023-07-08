using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Y_Polimorfismo
{
    abstract class Vehiculo//Clase Abstracta
    {
        //Atributo no abstracto
        private string nombre;

        //Propiedad no abstracta
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //Metodos
        public Vehiculo() { }//Constructor

        public abstract void Estacionarse();//Metodo Abstracto(Sera implementado en clases hijas)
    }
}
