using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Palabra_Reservada_Base
{
    internal class Clase_Hija : Clase_Padre
    {
        public override void Calcular()
        {
            base.Calcular();//Esta sentencia ejecuta el comportamiento común definido en la clase padre.

            x = x + 3;//Comportamiento particular de la clase hija.
            MessageBox.Show("Implementamos el comportamiento comun con la palabra reservada base y luego ejecutamos el comportamiento particular, x ahora vale " + x);
        }
    }
}
