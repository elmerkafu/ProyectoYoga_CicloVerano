namespace TestWindows_WCF_Reserva
{
    partial class UsuarioMan01
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
            dtgUsuarios = new DataGridView();
            Login_Usuario = new DataGridViewTextBoxColumn();
            Pass_Usuario = new DataGridViewTextBoxColumn();
            Niv_Usuario = new DataGridViewTextBoxColumn();
            Est_Usuario = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { Login_Usuario, Pass_Usuario, Niv_Usuario, Est_Usuario, Fec_Registro, Usu_Registro });
            dtgUsuarios.Location = new Point(29, 74);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 51;
            dtgUsuarios.RowTemplate.Height = 29;
            dtgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarios.Size = new Size(896, 267);
            dtgUsuarios.TabIndex = 0;
            // 
            // Login_Usuario
            // 
            Login_Usuario.DataPropertyName = "Login_Usuario";
            Login_Usuario.HeaderText = "Nombre de Usuario";
            Login_Usuario.MinimumWidth = 6;
            Login_Usuario.Name = "Login_Usuario";
            Login_Usuario.ReadOnly = true;
            // 
            // Pass_Usuario
            // 
            Pass_Usuario.DataPropertyName = "Pass_Usuario";
            Pass_Usuario.HeaderText = "Password";
            Pass_Usuario.MinimumWidth = 6;
            Pass_Usuario.Name = "Pass_Usuario";
            Pass_Usuario.ReadOnly = true;
            // 
            // Niv_Usuario
            // 
            Niv_Usuario.DataPropertyName = "Niv_Usuario";
            Niv_Usuario.HeaderText = "Nivel Usuario";
            Niv_Usuario.MinimumWidth = 6;
            Niv_Usuario.Name = "Niv_Usuario";
            Niv_Usuario.ReadOnly = true;
            // 
            // Est_Usuario
            // 
            Est_Usuario.DataPropertyName = "Est_Usuario";
            Est_Usuario.HeaderText = "Estado";
            Est_Usuario.MinimumWidth = 6;
            Est_Usuario.Name = "Est_Usuario";
            Est_Usuario.ReadOnly = true;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            Fec_Registro.HeaderText = "Fecha de Registro";
            Fec_Registro.MinimumWidth = 6;
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            Usu_Registro.DataPropertyName = "Usu_Registro";
            Usu_Registro.HeaderText = "Usuario Registro";
            Usu_Registro.MinimumWidth = 6;
            Usu_Registro.Name = "Usu_Registro";
            Usu_Registro.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(278, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(405, 388);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(538, 388);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(831, 388);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // UsuarioMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 462);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtgUsuarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Usuarios";
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn Login_Usuario;
        private DataGridViewTextBoxColumn Pass_Usuario;
        private DataGridViewTextBoxColumn Niv_Usuario;
        private DataGridViewTextBoxColumn Est_Usuario;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Usu_Registro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}