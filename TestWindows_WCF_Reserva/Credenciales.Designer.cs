namespace TestWindows_WCF_Reserva
{
    partial class Credenciales
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
            label4 = new Label();
            chkMinCaracter = new CheckBox();
            chkMinus = new CheckBox();
            chkMayus = new CheckBox();
            chkNum = new CheckBox();
            chkEspecial = new CheckBox();
            txtPass = new TextBox();
            btnGuardar = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 70);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 117);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 70);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Nivel de Acceso:";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(491, 69);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            // 
            // chkMinCaracter
            // 
            chkMinCaracter.AutoSize = true;
            chkMinCaracter.Location = new Point(247, 159);
            chkMinCaracter.Name = "chkMinCaracter";
            chkMinCaracter.Size = new Size(133, 19);
            chkMinCaracter.TabIndex = 4;
            chkMinCaracter.Text = "Mínimo 8 caracteres";
            chkMinCaracter.UseVisualStyleBackColor = true;
            // 
            // chkMinus
            // 
            chkMinus.AutoSize = true;
            chkMinus.Location = new Point(249, 197);
            chkMinus.Name = "chkMinus";
            chkMinus.Size = new Size(181, 19);
            chkMinus.TabIndex = 5;
            chkMinus.Text = "al menos una letra minúscula";
            chkMinus.UseVisualStyleBackColor = true;
            // 
            // chkMayus
            // 
            chkMayus.AutoSize = true;
            chkMayus.Location = new Point(247, 243);
            chkMayus.Name = "chkMayus";
            chkMayus.Size = new Size(183, 19);
            chkMayus.TabIndex = 6;
            chkMayus.Text = "al menos una letra mayúscula";
            chkMayus.UseVisualStyleBackColor = true;
            // 
            // chkNum
            // 
            chkNum.AutoSize = true;
            chkNum.Location = new Point(247, 286);
            chkNum.Name = "chkNum";
            chkNum.Size = new Size(136, 19);
            chkNum.TabIndex = 7;
            chkNum.Text = "al menos un número";
            chkNum.UseVisualStyleBackColor = true;
            // 
            // chkEspecial
            // 
            chkEspecial.AutoSize = true;
            chkEspecial.Location = new Point(247, 326);
            chkEspecial.Name = "chkEspecial";
            chkEspecial.Size = new Size(181, 19);
            chkEspecial.TabIndex = 8;
            chkEspecial.Text = "al menos un caracter especial";
            chkEspecial.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(247, 117);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(181, 23);
            txtPass.TabIndex = 9;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(302, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(211, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 23);
            comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 29);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(216, 28);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 23);
            txtUsuario.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 418);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Credenciales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 432);
            Controls.Add(txtUsuario);
            Controls.Add(comboBox1);
            Controls.Add(btnGuardar);
            Controls.Add(txtPass);
            Controls.Add(chkEspecial);
            Controls.Add(chkNum);
            Controls.Add(chkMayus);
            Controls.Add(chkMinus);
            Controls.Add(chkMinCaracter);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Credenciales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credenciales";
            Load += Credenciales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkMinCaracter;
        private CheckBox chkMinus;
        private CheckBox chkMayus;
        private CheckBox chkNum;
        private CheckBox chkEspecial;
        private TextBox txtPass;
        private Button btnGuardar;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtUsuario;
        private GroupBox groupBox1;
    }
}