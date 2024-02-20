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
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            lbl1 = new Label();
            lblRegistros = new Label();
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
            dtgUsuarios.DoubleClick += dtgUsuarios_DoubleClick;
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
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(407, 388);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(530, 388);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(655, 388);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(831, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(38, 396);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 20);
            lbl1.TabIndex = 2;
            lbl1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(126, 381);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 36);
            lblRegistros.TabIndex = 3;
            // 
            // UsuarioMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 462);
            Controls.Add(lblRegistros);
            Controls.Add(lbl1);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtgUsuarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Usuarios";
            Load += UsuarioMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn Login_Usuario;
        private DataGridViewTextBoxColumn Pass_Usuario;
        private DataGridViewTextBoxColumn Niv_Usuario;
        private DataGridViewTextBoxColumn Est_Usuario;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Usu_Registro;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private Label lbl1;
        private Label lblRegistros;
    }
}