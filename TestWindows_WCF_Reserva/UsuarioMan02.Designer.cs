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
            label2 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblUsuario = new Label();
            chkEspecial = new CheckBox();
            chkNum = new CheckBox();
            chkMayus = new CheckBox();
            chkMinus = new CheckBox();
            chkMinCaracter = new CheckBox();
            label15 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 98);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 66);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "Rol:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(190, 90);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(149, 23);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(190, 58);
            cboRol.Margin = new Padding(3, 2, 3, 2);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(149, 23);
            cboRol.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.Location = new Point(238, 747);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(137, 28);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Guardar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(411, 747);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 28);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 43);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "DNI:";
            // 
            // btnBuscarDatosReniec
            // 
            btnBuscarDatosReniec.Location = new Point(104, 74);
            btnBuscarDatosReniec.Name = "btnBuscarDatosReniec";
            btnBuscarDatosReniec.Size = new Size(154, 31);
            btnBuscarDatosReniec.TabIndex = 11;
            btnBuscarDatosReniec.Text = "Buscar Datos RENIEC";
            btnBuscarDatosReniec.UseVisualStyleBackColor = true;
            btnBuscarDatosReniec.Click += btnBuscarDatosReniec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 40);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "Nombres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 74);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 12;
            label6.Text = "Apellido Paterno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 116);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 12;
            label7.Text = "Apellido Materno";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Location = new Point(522, 108);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(227, 23);
            txtApeMaterno.TabIndex = 13;
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(158, 40);
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(100, 23);
            mskDNI.TabIndex = 14;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(522, 32);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(227, 23);
            txtNombres.TabIndex = 15;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Location = new Point(522, 71);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(227, 23);
            txtApePaterno.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 213);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 17;
            label8.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(122, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(227, 23);
            txtCorreo.TabIndex = 18;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(411, 206);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(84, 28);
            btnValidar.TabIndex = 19;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(571, 217);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 20;
            label9.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 168);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 21;
            label10.Text = "Fec. Nacimiento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 265);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 22;
            label11.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 257);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(373, 23);
            txtDireccion.TabIndex = 23;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(652, 213);
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 24;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(122, 168);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(124, 23);
            dtpFecNac.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 311);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 26;
            label12.Text = "Departamento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 353);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 27;
            label13.Text = "Provincia:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 398);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 28;
            label14.Text = "Distrito:";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(122, 303);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(121, 23);
            cboDepartamento.TabIndex = 29;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(122, 350);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(121, 23);
            cboProvincia.TabIndex = 30;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(122, 395);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(121, 23);
            cboDistrito.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(mskDNI);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboDepartamento);
            groupBox1.Controls.Add(btnBuscarDatosReniec);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(dtpFecNac);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(mskTelefono);
            groupBox1.Controls.Add(btnValidar);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtApePaterno);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtApeMaterno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 807);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del nuevo usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Controls.Add(chkEspecial);
            groupBox2.Controls.Add(chkNum);
            groupBox2.Controls.Add(chkMayus);
            groupBox2.Controls.Add(chkMinus);
            groupBox2.Controls.Add(chkMinCaracter);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(cboRol);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(64, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 281);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Credenciales";
            // 
            // lblUsuario
            // 
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Location = new Point(190, 28);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(280, 23);
            lblUsuario.TabIndex = 13;
            // 
            // chkEspecial
            // 
            chkEspecial.AutoSize = true;
            chkEspecial.Location = new Point(189, 227);
            chkEspecial.Name = "chkEspecial";
            chkEspecial.Size = new Size(181, 19);
            chkEspecial.TabIndex = 12;
            chkEspecial.Text = "al menos un caracter especial";
            chkEspecial.UseVisualStyleBackColor = true;
            // 
            // chkNum
            // 
            chkNum.AutoSize = true;
            chkNum.Location = new Point(189, 202);
            chkNum.Name = "chkNum";
            chkNum.Size = new Size(136, 19);
            chkNum.TabIndex = 11;
            chkNum.Text = "al menos un número";
            chkNum.UseVisualStyleBackColor = true;
            // 
            // chkMayus
            // 
            chkMayus.AutoSize = true;
            chkMayus.Location = new Point(189, 177);
            chkMayus.Name = "chkMayus";
            chkMayus.Size = new Size(183, 19);
            chkMayus.TabIndex = 10;
            chkMayus.Text = "al menos una letra mayúscula";
            chkMayus.UseVisualStyleBackColor = true;
            // 
            // chkMinus
            // 
            chkMinus.AutoSize = true;
            chkMinus.Location = new Point(189, 152);
            chkMinus.Name = "chkMinus";
            chkMinus.Size = new Size(181, 19);
            chkMinus.TabIndex = 9;
            chkMinus.Text = "al menos una letra minúscula";
            chkMinus.UseVisualStyleBackColor = true;
            // 
            // chkMinCaracter
            // 
            chkMinCaracter.Location = new Point(190, 127);
            chkMinCaracter.Name = "chkMinCaracter";
            chkMinCaracter.Size = new Size(133, 19);
            chkMinCaracter.TabIndex = 8;
            chkMinCaracter.Text = "Mínimo 8 caracteres";
            chkMinCaracter.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(376, 61);
            label15.Name = "label15";
            label15.Size = new Size(94, 15);
            label15.TabIndex = 7;
            label15.Text = "Nivel de Acceso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario:";
            // 
            // UsuarioMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 861);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Usuario";
            Load += UsuarioMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtPass;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private CheckBox chkEspecial;
        private CheckBox chkNum;
        private CheckBox chkMayus;
        private CheckBox chkMinus;
        private CheckBox chkMinCaracter;
        private Label label15;
        private Label lblUsuario;
    }
}