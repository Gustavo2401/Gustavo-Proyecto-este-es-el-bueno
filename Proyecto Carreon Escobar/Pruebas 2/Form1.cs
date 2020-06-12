using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_2
{
    
    public partial class Form1 : Form
    {
        Proyecto miOnlyFans = new Proyecto();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarEdad_Click(object sender, EventArgs e)
        {
            
            try
            {
                miOnlyFans.EdadVerificar = int.Parse(txtEdad.Text);
                if (miOnlyFans.EdadVerificar >= 18 && miOnlyFans.EdadVerificar <= 100)
                {
                    Cuenta_Usuario miCuenta = new Cuenta_Usuario();
                    miCuenta.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ingresa tu edad en forma de numeros." + x.Message , "Oh, oh" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEdad.Text = "";
                txtEdad.Clear();
                txtEdad.Focus();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEdad.Focus();
        }
    }
}
