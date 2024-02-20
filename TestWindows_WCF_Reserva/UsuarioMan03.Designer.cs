namespace TestWindows_WCF_Reserva
{
    partial class UsuarioMan03
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
            groupBox1 = new GroupBox();
            lblUsuario = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cboNivel = new ComboBox();
            txtPassword = new TextBox();
            chkEstado = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 63);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 112);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Nivel:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(cboNivel);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(26, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 333);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos a actualizar";
            // 
            // lblUsuario
            // 
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Location = new Point(124, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(179, 24);
            lblUsuario.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(209, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(90, 277);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboNivel
            // 
            cboNivel.FormattingEnabled = true;
            cboNivel.Location = new Point(124, 151);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(97, 28);
            cboNivel.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 27);
            txtPassword.TabIndex = 4;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(30, 205);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(80, 24);
            chkEstado.TabIndex = 3;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // UsuarioMan03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 401);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Usuario";
            Load += UsuarioMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label lblUsuario;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cboNivel;
        private TextBox txtPassword;
        private CheckBox chkEstado;
    }
}