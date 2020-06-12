namespace Pruebas_2
{
    partial class Cuenta_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAño1 = new System.Windows.Forms.ListBox();
            this.txtSerialTarjeta = new System.Windows.Forms.TextBox();
            this.lbMes1 = new System.Windows.Forms.ListBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnPagarMembresia = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.EtiquetaUsuario = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAccederPerfiles = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnPagarMembresia);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.EtiquetaUsuario);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.btnAccederPerfiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 426);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtContraseña);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbAño1);
            this.groupBox3.Controls.Add(this.txtSerialTarjeta);
            this.groupBox3.Controls.Add(this.lbMes1);
            this.groupBox3.Controls.Add(this.txtCVC);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtUsuario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(10, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 243);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Tarjeta";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(176, 214);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '$';
            this.txtContraseña.Size = new System.Drawing.Size(124, 23);
            this.txtContraseña.TabIndex = 20;
            this.txtContraseña.Validated += new System.EventHandler(this.txtContraseña_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contraseña:";
            // 
            // lbAño1
            // 
            this.lbAño1.FormattingEnabled = true;
            this.lbAño1.ItemHeight = 15;
            this.lbAño1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.lbAño1.Location = new System.Drawing.Point(79, 121);
            this.lbAño1.Name = "lbAño1";
            this.lbAño1.Size = new System.Drawing.Size(58, 19);
            this.lbAño1.TabIndex = 18;
            // 
            // txtSerialTarjeta
            // 
            this.txtSerialTarjeta.Location = new System.Drawing.Point(12, 52);
            this.txtSerialTarjeta.MaxLength = 16;
            this.txtSerialTarjeta.Name = "txtSerialTarjeta";
            this.txtSerialTarjeta.Size = new System.Drawing.Size(261, 23);
            this.txtSerialTarjeta.TabIndex = 2;
            this.txtSerialTarjeta.TextChanged += new System.EventHandler(this.txtSerialTarjeta_TextChanged);
            this.txtSerialTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialTarjeta_KeyPress);
            this.txtSerialTarjeta.Validated += new System.EventHandler(this.txtSerialTarjeta_Validated);
            // 
            // lbMes1
            // 
            this.lbMes1.FormattingEnabled = true;
            this.lbMes1.ItemHeight = 15;
            this.lbMes1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.lbMes1.Location = new System.Drawing.Point(12, 121);
            this.lbMes1.Name = "lbMes1";
            this.lbMes1.Size = new System.Drawing.Size(56, 19);
            this.lbMes1.TabIndex = 17;
            this.lbMes1.Validated += new System.EventHandler(this.lbMes1_Validated);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(175, 117);
            this.txtCVC.MaxLength = 3;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(76, 23);
            this.txtCVC.TabIndex = 3;
            this.txtCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVC_KeyPress);
            this.txtCVC.Validated += new System.EventHandler(this.txtCVC_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(76, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Año (AA)";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 214);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(124, 23);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Validated += new System.EventHandler(this.txtUsuario_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mes (MM)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(9, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Ingresa tu tarjeta de credito (16 digitos)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Cyan;
            this.label13.Location = new System.Drawing.Point(9, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Fecha de vencimiento\'";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(172, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Codigo CVC";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(13, 170);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(287, 23);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            this.txtCorreo.Validated += new System.EventHandler(this.txtCorreo_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Cyan;
            this.label15.Location = new System.Drawing.Point(10, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Correo Electronco";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Cyan;
            this.label16.Location = new System.Drawing.Point(10, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Usuario";
            // 
            // btnPagarMembresia
            // 
            this.btnPagarMembresia.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPagarMembresia.BackgroundImage = global::Pruebas_2.Properties.Resources.BL_enjoyable_by_nanatrex;
            this.btnPagarMembresia.Font = new System.Drawing.Font("Sexy Beauty", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarMembresia.ForeColor = System.Drawing.Color.Cyan;
            this.btnPagarMembresia.Location = new System.Drawing.Point(22, 352);
            this.btnPagarMembresia.Name = "btnPagarMembresia";
            this.btnPagarMembresia.Size = new System.Drawing.Size(135, 56);
            this.btnPagarMembresia.TabIndex = 12;
            this.btnPagarMembresia.Text = "Pagar";
            this.btnPagarMembresia.UseVisualStyleBackColor = false;
            this.btnPagarMembresia.Click += new System.EventHandler(this.btnPagarMembresia_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Cyan;
            this.label17.Location = new System.Drawing.Point(38, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sexy Beauty", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Cyan;
            this.label18.Location = new System.Drawing.Point(0, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(319, 62);
            this.label18.TabIndex = 6;
            this.label18.Text = "Hola, la suscripcion a OnlyFans\r\n    tiene un costo de $200\r\n";
            // 
            // EtiquetaUsuario
            // 
            this.EtiquetaUsuario.AutoSize = true;
            this.EtiquetaUsuario.ForeColor = System.Drawing.Color.Cyan;
            this.EtiquetaUsuario.Location = new System.Drawing.Point(22, 16);
            this.EtiquetaUsuario.Name = "EtiquetaUsuario";
            this.EtiquetaUsuario.Size = new System.Drawing.Size(35, 13);
            this.EtiquetaUsuario.TabIndex = 5;
            this.EtiquetaUsuario.Text = "label2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(292, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "label19";
            // 
            // btnAccederPerfiles
            // 
            this.btnAccederPerfiles.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAccederPerfiles.BackgroundImage = global::Pruebas_2.Properties.Resources.BL_enjoyable_by_nanatrex;
            this.btnAccederPerfiles.Font = new System.Drawing.Font("Sexy Beauty", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccederPerfiles.ForeColor = System.Drawing.Color.Cyan;
            this.btnAccederPerfiles.Location = new System.Drawing.Point(172, 352);
            this.btnAccederPerfiles.Name = "btnAccederPerfiles";
            this.btnAccederPerfiles.Size = new System.Drawing.Size(138, 56);
            this.btnAccederPerfiles.TabIndex = 0;
            this.btnAccederPerfiles.Text = "Acceder";
            this.btnAccederPerfiles.UseVisualStyleBackColor = false;
            this.btnAccederPerfiles.Click += new System.EventHandler(this.btnAccederPerfiles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnSalir.BackgroundImage = global::Pruebas_2.Properties.Resources.Screenshot_2017_08_11_00_44_40;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Sexy Beauty", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Cyan;
            this.btnSalir.Location = new System.Drawing.Point(696, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 53);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.CVC,
            this.Correo,
            this.Usuario,
            this.Contraseña});
            this.dgvClientes.Location = new System.Drawing.Point(342, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(457, 352);
            this.dgvClientes.TabIndex = 22;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // CVC
            // 
            this.CVC.HeaderText = "CVC";
            this.CVC.Name = "CVC";
            this.CVC.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // Cuenta_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pruebas_2.Properties.Resources.BL_enjoyable_by_nanatrex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cuenta_Usuario";
            this.Text = "Cuenta_Usuario";
            this.Load += new System.EventHandler(this.Cuenta_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAño1;
        private System.Windows.Forms.TextBox txtSerialTarjeta;
        private System.Windows.Forms.ListBox lbMes1;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPagarMembresia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label EtiquetaUsuario;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAccederPerfiles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
    }
}