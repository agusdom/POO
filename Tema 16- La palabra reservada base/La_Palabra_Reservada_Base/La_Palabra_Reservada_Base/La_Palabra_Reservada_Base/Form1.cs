using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Palabra_Reservada_Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase hija
            Clase_Hija hijo = new Clase_Hija();

            //Ejecutamos el método calcular.El mismo va a invocar primero el método
            //de la clase padre (implementando el comportamiento común) y luego
            //va a ejecutar el comportamiento particular.
            hijo.Calcular();

        }
    }
}
