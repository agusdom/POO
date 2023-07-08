using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validarStringRespuesta = Utiles.validarCampo(textBox1.Text, "String");
            if (!validarStringRespuesta)
            {
                textBox1.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
            }

            bool validarIntRespuesta = Utiles.validarCampo(textBox2.Text, "Int");
            if (!validarIntRespuesta)
            {
                textBox2.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }

            bool validarFloatRespuesta = Utiles.validarCampo(textBox3.Text, "Float");
            if (!validarFloatRespuesta)
            {
                textBox3.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
