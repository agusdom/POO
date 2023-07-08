using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Palabra_Reservada_Base
{
    internal class Clase_Padre
    {
        public int x;

        public virtual void Calcular()
        {
            //Definimos el comportamiento común que tendrán las clases hijas.
            x = 1;
            MessageBox.Show("Inicialmente x vale " + x);
        }
    }
}
