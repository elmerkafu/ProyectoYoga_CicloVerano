﻿namespace TestWindows_WCF_Reserva
{
    partial class InstructorMan03
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
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            lblCodigo = new Label();
            label11 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkActivo = new CheckBox();
            dtpFecNac = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
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
            txtNombre = new TextBox();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(label13);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(lblCodigo);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(dtpFecNac);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label8);
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
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(15, 15);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(609, 515);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 414);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 39;
            label10.Text = "Distrito:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 367);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 38;
            label12.Text = "Provincia:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 329);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 37;
            label13.Text = "Departamento:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(145, 406);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(210, 23);
            cboDistrito.TabIndex = 36;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(145, 364);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(210, 23);
            cboProvincia.TabIndex = 35;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(145, 326);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(210, 23);
            cboDepartamento.TabIndex = 34;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(145, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(74, 23);
            lblCodigo.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 32);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 21;
            label11.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(509, 468);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(412, 468);
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
            chkActivo.Location = new Point(27, 474);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(65, 19);
            chkActivo.TabIndex = 11;
            chkActivo.Text = "Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(145, 226);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(103, 23);
            dtpFecNac.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 226);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 17;
            label9.Text = "Fec. Nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(634, 218);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(145, 194);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(448, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 197);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Dirección:";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(145, 286);
            mskDNI.Mask = "00000000";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(100, 23);
            mskDNI.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 289);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "DNI:";
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(145, 257);
            mskTelefono.Mask = "000000000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 260);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(145, 164);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(227, 23);
            txtCorreo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 165);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Location = new Point(145, 132);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(227, 23);
            txtApeMaterno.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido Materno:";
            // 
            // txtApePaterno
            // 
            txtApePaterno.Location = new Point(145, 96);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(227, 23);
            txtApePaterno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 101);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // InstructorMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 538);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstructorMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Instructor";
            Load += InstructorMan03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal Button btnCancelar;
        internal Button btnGrabar;
        private CheckBox chkActivo;
        private DateTimePicker dtpFecNac;
        private Label label9;
        private Label label8;
        private TextBox txtDireccion;
        private Label label7;
        private MaskedTextBox mskDNI;
        private Label label6;
        private MaskedTextBox mskTelefono;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtApeMaterno;
        private Label label3;
        private TextBox txtApePaterno;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label11;
        internal Label lblCodigo;
        private Label label10;
        private Label label12;
        private Label label13;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
    }
}