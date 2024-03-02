namespace TestWindows_WCF_Reserva
{
    partial class UsuarioMan02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            cboRol = new ComboBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            btnBuscarDatosReniec = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtApeMaterno = new TextBox();
            mskDNI = new MaskedTextBox();
            txtNombres = new TextBox();
            txtApePaterno = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            btnValidar = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtDireccion = new TextBox();
            mskTelefono = new MaskedTextBox();
            dtpFecNac = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 317);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 431);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 464);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "Rol:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(687, 315);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(149, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(379, 425);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 23);
            txtPassword.TabIndex = 3;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(379, 458);
            cboRol.Margin = new Padding(3, 2, 3, 2);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(116, 23);
            cboRol.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(297, 518);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(82, 22);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 518);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 50);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "DNI:";
            // 
            // btnBuscarDatosReniec
            // 
            btnBuscarDatosReniec.Location = new Point(72, 101);
            btnBuscarDatosReniec.Name = "btnBuscarDatosReniec";
            btnBuscarDatosReniec.Size = new Size(184, 23);
            btnBuscarDatosReniec.TabIndex = 11;
            btnBuscarDatosReniec.Text = "Buscar Datos RENIEC";
            btnBuscarDatosReniec.UseVisualStyleBackColor = true;
            btnBuscarDatosReniec.Click += btnBuscarDatosReniec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 42);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "Nombres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 75);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 12;
            label6.Text = "Apellido Paterno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 113);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 12;
            label7.Text = "Apellido Materno";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Location = new Point(534, 105);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(162, 23);
            txtApeMaterno.TabIndex = 13;
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(136, 47);
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(100, 23);
            mskDNI.TabIndex = 14;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(534, 34);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(162, 23);
            txtNombres.TabIndex = 15;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Location = new Point(534, 72);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(162, 23);
            txtApePaterno.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 161);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 17;
            label8.Text = "Usuario - Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(222, 161);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(281, 23);
            txtCorreo.TabIndex = 18;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(561, 162);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 19;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 204);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 20;
            label9.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 239);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 21;
            label10.Text = "Fec. Nacimiento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 270);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 22;
            label11.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(222, 267);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(280, 23);
            txtDireccion.TabIndex = 23;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(222, 196);
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 24;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(221, 233);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(124, 23);
            dtpFecNac.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(89, 315);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 26;
            label12.Text = "Departamento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(88, 354);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 27;
            label13.Text = "Provincia:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(88, 386);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 28;
            label14.Text = "Distrito:";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(221, 307);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(121, 23);
            cboDepartamento.TabIndex = 29;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(221, 346);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(121, 23);
            cboProvincia.TabIndex = 30;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(221, 378);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(121, 23);
            cboDistrito.TabIndex = 31;
            // 
            // UsuarioMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 590);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
            Controls.Add(cboDepartamento);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dtpFecNac);
            Controls.Add(mskTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnValidar);
            Controls.Add(txtCorreo);
            Controls.Add(label8);
            Controls.Add(txtApePaterno);
            Controls.Add(txtNombres);
            Controls.Add(mskDNI);
            Controls.Add(txtApeMaterno);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBuscarDatosReniec);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(cboRol);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Usuario";
            Load += UsuarioMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private ComboBox cboRol;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtDireccion;
        private Button btnBuscarDatosReniec;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtApeMaterno;
        private MaskedTextBox mskDNI;
        private TextBox txtNombres;
        private TextBox txtApePaterno;
        private Label label8;
        private TextBox txtCorreo;
        private Button btnValidar;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox mskTelefono;
        private DateTimePicker dtpFecNac;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
    }
}