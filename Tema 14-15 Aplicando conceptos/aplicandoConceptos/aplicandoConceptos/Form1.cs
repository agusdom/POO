using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicandoConceptos
{
    public partial class FrmPrincipal : Form
    {
        //Atributo de la clase Form1
        ArrayList listaClientes = new ArrayList();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonSaludo_Click(object sender, EventArgs e)
        {
            String nombre = textNombre.Text;
            String apellido = textApellido.Text;
            String dni = textDNI.Text;
            MessageBox.Show($"Hola {nombre} {apellido}.Bienvenido al sistema","Bienvenido!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Cliente c = new Cliente(nombre,apellido,dni);

            bool existe = false;
            foreach(Cliente cli in listaClientes)
            {
                if (cli.Dni == c.Dni)
                {
                 existe = true;   
                }
            }

            if (!existe)
            {
                listaClientes.Add(c);
            }
            else
            {
                MessageBox.Show("Ya existe un cliente con ese DNI.");
            }
           

            
          
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDNI.Text = "";
        }

        private void buttonMostrarPersonas_Click(object sender, EventArgs e)
        {
            labelLista.Text = null;
            foreach(Cliente i in listaClientes)
            {
                labelLista.Text = labelLista.Text + "\n Nombre:" + i.Nombre; 
                labelLista.Text = labelLista.Text + "\n Apellido:" + i.Apellido;
                labelLista.Text = labelLista.Text + "\n Dni:" + i.Dni;
                labelLista.Text = labelLista.Text + "\n-------------------------------------------";
            }
        }

       
    }
}
