namespace TestWindows_WCF_Reserva
{
    partial class InstructorMan01
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
            dtgInstructor = new DataGridView();
            Id_Instructor = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Tel_inst = new DataGridViewTextBoxColumn();
            Dni_inst = new DataGridViewTextBoxColumn();
            Dir_inst = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            EstadoInst = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            lblRegistros = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgInstructor).BeginInit();
            SuspendLayout();
            // 
            // dtgInstructor
            // 
            dtgInstructor.AllowUserToAddRows = false;
            dtgInstructor.AllowUserToDeleteRows = false;
            dtgInstructor.AllowUserToResizeRows = false;
            dtgInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgInstructor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInstructor.ColumnHeadersHeight = 30;
            dtgInstructor.Columns.AddRange(new DataGridViewColumn[] { Id_Instructor, NombreCompleto, Correo, Tel_inst, Dni_inst, Dir_inst, Departamento, Provincia, Distrito, EstadoInst });
            dtgInstructor.Location = new Point(12, 12);
            dtgInstructor.Margin = new Padding(2, 1, 2, 1);
            dtgInstructor.Name = "dtgInstructor";
            dtgInstructor.ReadOnly = true;
            dtgInstructor.RowHeadersVisible = false;
            dtgInstructor.RowHeadersWidth = 82;
            dtgInstructor.RowTemplate.Height = 41;
            dtgInstructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInstructor.Size = new Size(1065, 459);
            dtgInstructor.TabIndex = 0;
            dtgInstructor.DoubleClick += dtgInstructor_DoubleClick;
            // 
            // Id_Instructor
            // 
            Id_Instructor.DataPropertyName = "Id_Instructor";
            Id_Instructor.FillWeight = 42.30118F;
            Id_Instructor.HeaderText = "Codigo";
            Id_Instructor.MinimumWidth = 10;
            Id_Instructor.Name = "Id_Instructor";
            Id_Instructor.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre de Instructor";
            NombreCompleto.MinimumWidth = 4;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.FillWeight = 42.30118F;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 10;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Tel_inst
            // 
            Tel_inst.DataPropertyName = "Tel_inst";
            Tel_inst.FillWeight = 42.30118F;
            Tel_inst.HeaderText = "Telefono";
            Tel_inst.MinimumWidth = 10;
            Tel_inst.Name = "Tel_inst";
            Tel_inst.ReadOnly = true;
            // 
            // Dni_inst
            // 
            Dni_inst.DataPropertyName = "Dni_inst";
            Dni_inst.FillWeight = 42.30118F;
            Dni_inst.HeaderText = "DNI";
            Dni_inst.MinimumWidth = 10;
            Dni_inst.Name = "Dni_inst";
            Dni_inst.ReadOnly = true;
            // 
            // Dir_inst
            // 
            Dir_inst.DataPropertyName = "Dir_inst";
            Dir_inst.FillWeight = 42.30118F;
            Dir_inst.HeaderText = "Direccion";
            Dir_inst.MinimumWidth = 10;
            Dir_inst.Name = "Dir_inst";
            Dir_inst.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.FillWeight = 42.30118F;
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.FillWeight = 42.30118F;
            Provincia.HeaderText = "Provincia";
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.FillWeight = 42.30118F;
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // EstadoInst
            // 
            EstadoInst.DataPropertyName = "EstadoInst";
            EstadoInst.FillWeight = 42.30118F;
            EstadoInst.HeaderText = "Estado";
            EstadoInst.MinimumWidth = 10;
            EstadoInst.Name = "EstadoInst";
            EstadoInst.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(989, 484);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.Location = new Point(797, 484);
            btnActualizar.Margin = new Padding(4, 3, 4, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 27);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Location = new Point(701, 484);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 27);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(86, 483);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(63, 26);
            lblRegistros.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 484);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 16;
            label1.Text = "Registros:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(893, 484);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // InstructorMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 520);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgInstructor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstructorMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Instructor";
            Load += InstructorMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInstructor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgInstructor;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private Label lblRegistros;
        private Label label1;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Id_Instructor;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Tel_inst;
        private DataGridViewTextBoxColumn Dni_inst;
        private DataGridViewTextBoxColumn Dir_inst;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn EstadoInst;
    }
}