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
using System.Net.Mail;

namespace Pruebas_2
{
    public partial class Cuenta_Usuario : Form
    {
        
        public Cuenta_Usuario()
        {
            InitializeComponent();
            
        }

        private void Cuenta_Usuario_Load(object sender, EventArgs e)
        {
            btnAccederPerfiles.Enabled = false;
        }

        private void btnAccederPerfiles_Click(object sender, EventArgs e)
        {
        //=====================================================
            Contenido_de_prueba miContenido = new Contenido_de_prueba();
            miContenido.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        MySqlConnection ConexionDatabase = new MySqlConnection("Server=localhost; Database=gusdatabase;uid=gustabot;pwd=1234");
        private void btnPagarMembresia_Click(object sender, EventArgs e)
        {
            
                Proyecto miOnlyfans3 = new Proyecto();
                miOnlyfans3.NumeroTarjeta = (txtSerialTarjeta.Text);
                miOnlyfans3.CodigoCVC = (txtCVC.Text);
                miOnlyfans3.Correo = (txtCorreo.Text);
                miOnlyfans3.Usuario = (txtUsuario.Text);
                miOnlyfans3.Contraseña = (txtContraseña.Text);
                

            if (miOnlyfans3.Usuario == "" || miOnlyfans3.Correo == "" || miOnlyfans3.Contraseña == "" || miOnlyfans3.NumeroTarjeta == "" || miOnlyfans3.CodigoCVC == "" || lbMes1.SelectedIndex == -1 || lbAño1.SelectedIndex == -1)
            {
                MessageBox.Show("Necesitas Registrarte para poder disfrutar de los beneficios de OnlyFans.", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    
                    dgvClientes.Rows.Add();
                    int cantFilas = dgvClientes.Rows.Count-1;
                    dgvClientes[0, cantFilas].Value = txtSerialTarjeta.Text;
                    dgvClientes[1, cantFilas].Value = txtCVC.Text;
                    dgvClientes[2, cantFilas].Value = txtCorreo.Text;
                    dgvClientes[3, cantFilas].Value = txtUsuario.Text;
                    dgvClientes[4, cantFilas].Value = txtContraseña.Text;
                 //---------------------------Base de datos-------------------------------------------------

                    ConexionDatabase.Open();
                    string Query = "INSERT INTO datosusuario(Serial,CVC,Correo,Usuario,Password) values ('" + txtSerialTarjeta.Text + "' , '" + txtCVC.Text + "' , '" + txtCorreo.Text + "' , '" + txtUsuario.Text + "' , '" + txtContraseña.Text + "');";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionDatabase);
                    comando.ExecuteNonQuery();
                    ConexionDatabase.Close();
                    //Delegado
                    try
                    {
                        Proyecto miCalculo = new Proyecto();
                        MessageBox.Show("Querido " + txtUsuario.Text + ", Su tarjeta (" + txtSerialTarjeta.Text + ") ha echo el pago de la suscripcion de $200.", "Felicitaciones" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Saldo Total: " + miCalculo.Calcular(miCalculo.CalcularTransaccion));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                    //=======================================================
                    try
                    {
                        string CorreoRemitente = "sistemascodigo245@gmail.com";
                        string CorreoDestinatario = txtCorreo.Text;
                        string Contraseña = "Codigo2401";

                        MailMessage miMailMessage = new MailMessage(CorreoRemitente, CorreoDestinatario, "Bienvenido a OnlyFans " + txtUsuario.Text, "<v>Espero Que disfrutes del mejor contenido de OnlyFans </b>");
                        miMailMessage.IsBodyHtml = true;

                        SmtpClient miSmtpClient = new SmtpClient("smtp.gmail.com");
                        miSmtpClient.EnableSsl = true;
                        miSmtpClient.UseDefaultCredentials = false;
                        miSmtpClient.Port = 587;
                        miSmtpClient.Credentials = new System.Net.NetworkCredential(CorreoRemitente, Contraseña);

                        miSmtpClient.Send(miMailMessage);
                        miSmtpClient.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido enviarte un correo. " + ex.Message, "Oh, oh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //========================================================
                    btnPagarMembresia.Enabled = false;
                    btnAccederPerfiles.Enabled = true;
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR. " + ex.Message);
                }

                     
            }
            
        }

        private void txtSerialTarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerialTarjeta_Validated(object sender, EventArgs e)
        {
            if (txtSerialTarjeta.Text.Trim() == "")
            {
                epError.SetError(txtSerialTarjeta, "No deje Espacios en Blanco. Agregue el Serial de la tarjeta.");
                txtSerialTarjeta.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCVC_Validated(object sender, EventArgs e)
        {
            if (txtCVC.Text.Trim() == "")
            {
                epError.SetError(txtCVC, "No deje Espacios en Blanco. Agregue el Codigo de la tarjeta.");
                txtCVC.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                epError.SetError(txtCorreo, "No deje Espacios en Blanco. Agregue algun Correo.");
                txtCorreo.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "No deje Espacios en Blanco. Agregue unUsuario.");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                epError.SetError(txtContraseña, "No deje Espacios en Blanco. Agregue una Contraseña.");
                txtContraseña.Focus();
            }
            else
            {
                epError.Clear();
            }

        }


        private void txtCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proyecto miValidacion = new Proyecto();
            miValidacion.SoloNumeros(e);
        }

        private void lbMes1_Validated(object sender, EventArgs e)
        {

        }

        private void txtSerialTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proyecto miValidacion = new Proyecto();
            miValidacion.SoloNumeros(e);
        }
    }
}
