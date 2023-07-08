using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usoCorrectoPropiedades
{
    public partial class Form1 : Form
    {
        //Atributos de Clase
        Usuario u;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u = new Usuario(textNombre.Text, textApellido.Text, textDni.Text, textEmail.Text, textDireccion.Text);

            MessageBox.Show("El usuario ha sido registrado con éxito: \n" + u.Nombre + "\n" + u.Apellido + "\n" + u.Email + "\n" + u.Dni + "\n" + u.Direccion);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            u.Direccion = textDireccion.Text;
            MessageBox.Show("Se actualizo el campo de dirección: \n" + u.Nombre + "\n" + u.Apellido + "\n" + u.Email + "\n" + u.Dni + "\n" + u.Direccion);
        }
    }
}
