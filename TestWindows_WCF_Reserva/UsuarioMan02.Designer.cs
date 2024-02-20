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
            cboNivel = new ComboBox();
            chkEstado = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 75);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 117);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Nivel:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(202, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 27);
            txtPassword.TabIndex = 3;
            // 
            // cboNivel
            // 
            cboNivel.FormattingEnabled = true;
            cboNivel.Location = new Point(202, 153);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(132, 28);
            cboNivel.TabIndex = 5;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(87, 210);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(80, 24);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(137, 291);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(278, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // UsuarioMan02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 388);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkEstado);
            Controls.Add(cboNivel);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private ComboBox cboNivel;
        private CheckBox chkEstado;
        private Button btnGrabar;
        private Button btnCancelar;
    }
}