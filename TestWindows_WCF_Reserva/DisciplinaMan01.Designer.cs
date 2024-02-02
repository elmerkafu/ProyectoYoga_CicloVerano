namespace TestWindows_WCF_Reserva
{
    partial class DisciplinaMan01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgDisciplina = new DataGridView();
            Cod_disp = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Intensidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDisciplina).BeginInit();
            SuspendLayout();
            // 
            // dtgDisciplina
            // 
            dtgDisciplina.AllowUserToAddRows = false;
            dtgDisciplina.AllowUserToDeleteRows = false;
            dtgDisciplina.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDisciplina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDisciplina.ColumnHeadersHeight = 30;
            dtgDisciplina.Columns.AddRange(new DataGridViewColumn[] { Cod_disp, Nombre, Duracion, Intensidad, Precio, Categoria });
            dtgDisciplina.Location = new Point(12, 12);
            dtgDisciplina.Name = "dtgDisciplina";
            dtgDisciplina.ReadOnly = true;
            dtgDisciplina.RowHeadersVisible = false;
            dtgDisciplina.RowTemplate.Height = 25;
            dtgDisciplina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDisciplina.Size = new Size(908, 386);
            dtgDisciplina.TabIndex = 0;
            dtgDisciplina.DoubleClick += dtgDisciplina_DoubleClick;
            // 
            // Cod_disp
            // 
            Cod_disp.DataPropertyName = "Cod_disp";
            Cod_disp.HeaderText = "Cod. Disciplina";
            Cod_disp.Name = "Cod_disp";
            Cod_disp.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duración ";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // Intensidad
            // 
            Intensidad.DataPropertyName = "Intensidad";
            Intensidad.HeaderText = "Intensidad";
            Intensidad.Name = "Intensidad";
            Intensidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            Precio.DefaultCellStyle = dataGridViewCellStyle1;
            Precio.HeaderText = "Precio S/.";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 443);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(95, 442);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 23);
            lblRegistros.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(507, 474);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 27);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(617, 474);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 27);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(832, 474);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(727, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // DisciplinaMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 513);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgDisciplina);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisciplinaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Disciplina";
            Load += DisciplinaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDisciplina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDisciplina;
        private Label label1;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Cod_disp;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Intensidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Categoria;
    }
}