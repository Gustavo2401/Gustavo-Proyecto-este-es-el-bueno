using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace Pruebas_2
{
    public partial class Contenido_de_prueba : Form
    {
        
        public Contenido_de_prueba()
        {
            InitializeComponent();
        }

        private void Contenido_de_prueba_Load(object sender, EventArgs e)
        {
            Proyecto miOnlyfans3 = new Proyecto();

            label1.Text = miOnlyfans3.Usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFreshman_Click(object sender, EventArgs e)
        {

        }

        private void btnIrASuscribirsePremium_Click(object sender, EventArgs e)
        {
            DessirePerfil miSuscripcion = new DessirePerfil();
            miSuscripcion.Show();
        }

        private void btnFreshman_Click_1(object sender, EventArgs e)
        {
            Perfil_de_Freshman miSuscripcion = new Perfil_de_Freshman();
            miSuscripcion.Show();
        }

        private void btnDessiree_Click(object sender, EventArgs e)
        {
            DessirePerfil miSuscripcion = new DessirePerfil();
            miSuscripcion.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
