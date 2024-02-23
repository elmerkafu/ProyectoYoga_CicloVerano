namespace TestWindows_WCF_Reserva
{
    partial class SalonMan01
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
            dtgSalon = new DataGridView();
            Id_Salon = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgSalon).BeginInit();
            SuspendLayout();
            // 
            // dtgSalon
            // 
            dtgSalon.AllowUserToAddRows = false;
            dtgSalon.AllowUserToDeleteRows = false;
            dtgSalon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgSalon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSalon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSalon.Columns.AddRange(new DataGridViewColumn[] { Id_Salon, Nombre, Area, Capacidad, Estado, Descripcion });
            dtgSalon.Location = new Point(12, 12);
            dtgSalon.Name = "dtgSalon";
            dtgSalon.ReadOnly = true;
            dtgSalon.RowHeadersVisible = false;
            dtgSalon.RowTemplate.Height = 25;
            dtgSalon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSalon.Size = new Size(776, 355);
            dtgSalon.TabIndex = 0;
            dtgSalon.DoubleClick += dtgSalon_DoubleClick;
            // 
            // Id_Salon
            // 
            Id_Salon.DataPropertyName = "Id_Salon";
            Id_Salon.HeaderText = "Cod Salon";
            Id_Salon.Name = "Id_Salon";
            Id_Salon.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Area
            // 
            Area.DataPropertyName = "Area";
            Area.HeaderText = "Area";
            Area.Name = "Area";
            Area.ReadOnly = true;
            // 
            // Capacidad
            // 
            Capacidad.DataPropertyName = "Capacidad";
            Capacidad.HeaderText = "Capacidad";
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "EstadoTexto";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 412);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(89, 411);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(63, 26);
            lblRegistros.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(418, 408);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 27);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(700, 408);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(512, 408);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 27);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(606, 408);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // SalonMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgSalon);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalonMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Salon ";
            Load += SalonMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSalon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgSalon;
        private Label label1;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Id_Salon;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnInsertar;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}