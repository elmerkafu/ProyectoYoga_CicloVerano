namespace TestWindows_WCF_Reserva
{
    partial class ClienteMan02
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
            grpDatos = new GroupBox();
            btnValidar = new Button();
            btnBuscarDatosReniec = new Button();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            groupBox1 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkActivo = new CheckBox();
            dtpFecNac = new DateTimePicker();
            label9 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            mskDNI = new MaskedTextBox();
            label6 = new Label();
            mskTelefono = new MaskedTextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtApeMaterno = new TextBox();
            label3 = new Label();
            txtApePaterno = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnValidar);
            grpDatos.Controls.Add(btnBuscarDatosReniec);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(groupBox1);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(dtpFecNac);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(mskDNI);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtApeMaterno);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtApePaterno);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtNombres);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(811, 483);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Cliente";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(405, 165);
            btnValidar.Margin = new Padding(4, 3, 4, 3);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(84, 28);
            btnValidar.TabIndex = 36;
            btnValidar.Text = "Validar";
            btnValidar.Click += btnValidar_Click;
            // 
            // btnBuscarDatosReniec
            // 
            btnBuscarDatosReniec.Location = new Point(105, 74);
            btnBuscarDatosReniec.Margin = new Padding(4, 3, 4, 3);
            btnBuscarDatosReniec.Name = "btnBuscarDatosReniec";
            btnBuscarDatosReniec.Size = new Size(154, 31);
            btnBuscarDatosReniec.TabIndex = 28;
            btnBuscarDatosReniec.Text = "Buscar Datos RENIEC";
            btnBuscarDatosReniec.Click += btnBuscarDatosReniec_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 417);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 27;
            label11.Text = "Distrito:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 370);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 26;
            label10.Text = "Provincia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 332);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 25;
            label8.Text = "Departamento:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(128, 409);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(210, 23);
            cboDistrito.TabIndex = 24;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(128, 367);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(210, 23);
            cboProvincia.TabIndex = 23;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(128, 329);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(210, 23);
            cboDepartamento.TabIndex = 22;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optFemenino);
            groupBox1.Controls.Add(optMasculino);
            groupBox1.Location = new Point(631, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 86);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género:";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(23, 47);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(78, 19);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(23, 22);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(723, 449);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.Location = new Point(631, 449);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 12;
            btnGrabar.Text = "Grabar";
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(559, 455);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(65, 19);
            chkActivo.TabIndex = 11;
            chkActivo.Text = "Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(128, 260);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(103, 23);
            dtpFecNac.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 266);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 17;
            label9.Text = "Fec. Nacimiento:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 212);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(448, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 215);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Dirección:";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(159, 37);
            mskDNI.Mask = "00000000";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(100, 23);
            mskDNI.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 40);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "DNI:";
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(654, 169);
            mskTelefono.Mask = "000000000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 172);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(128, 169);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(227, 23);
            txtCorreo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 172);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Enabled = false;
            txtApeMaterno.Location = new Point(527, 117);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(227, 23);
            txtApeMaterno.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 120);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido Materno:";
            // 
            // txtApePaterno
            // 
            txtApePaterno.Enabled = false;
            txtApePaterno.Location = new Point(527, 74);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(227, 23);
            txtApePaterno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 77);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido Paterno:";
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Location = new Point(527, 32);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(227, 23);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // ClienteMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 507);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Cliente";
            Load += ClienteMan02_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtNombres;
        private Label label1;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtApeMaterno;
        private Label label3;
        private TextBox txtApePaterno;
        private Label label2;
        private MaskedTextBox mskTelefono;
        private Label label5;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private MaskedTextBox mskDNI;
        private CheckBox chkActivo;
        private DateTimePicker dtpFecNac;
        private Label label9;
        internal Button btnCancelar;
        internal Button btnGrabar;
        private GroupBox groupBox1;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private Label label8;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private Label label11;
        private Label label10;
        internal Button btnBuscarDatosReniec;
        internal Button btnValidar;
    }
}