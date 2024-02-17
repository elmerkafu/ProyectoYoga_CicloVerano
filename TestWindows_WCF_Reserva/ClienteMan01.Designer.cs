namespace TestWindows_WCF_Reserva
{
    partial class ClienteMan01
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
            dtgCliente = new DataGridView();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            ApePaterno = new DataGridViewTextBoxColumn();
            ApeMaterno = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Nacimiento = new DataGridViewTextBoxColumn();
            SexoTexto = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            EstadoTexto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgCliente).BeginInit();
            SuspendLayout();
            // 
            // dtgCliente
            // 
            dtgCliente.AllowUserToAddRows = false;
            dtgCliente.AllowUserToDeleteRows = false;
            dtgCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCliente.ColumnHeadersHeight = 30;
            dtgCliente.Columns.AddRange(new DataGridViewColumn[] { Id_Cliente, Nombres, ApePaterno, ApeMaterno, Correo, Telefono, Direccion, DNI, Nacimiento, SexoTexto, Departamento, Provincia, Distrito, EstadoTexto });
            dtgCliente.Location = new Point(14, 60);
            dtgCliente.Margin = new Padding(3, 4, 3, 4);
            dtgCliente.Name = "dtgCliente";
            dtgCliente.ReadOnly = true;
            dtgCliente.RowHeadersVisible = false;
            dtgCliente.RowHeadersWidth = 51;
            dtgCliente.RowTemplate.Height = 25;
            dtgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCliente.Size = new Size(1241, 546);
            dtgCliente.TabIndex = 0;
            dtgCliente.DoubleClick += dtgCliente_DoubleClick;
            // 
            // Id_Cliente
            // 
            Id_Cliente.DataPropertyName = "Id_Cliente";
            Id_Cliente.HeaderText = "Id";
            Id_Cliente.MinimumWidth = 6;
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.ReadOnly = true;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            // 
            // ApePaterno
            // 
            ApePaterno.DataPropertyName = "ApePaterno";
            ApePaterno.HeaderText = "ApePaterno";
            ApePaterno.MinimumWidth = 6;
            ApePaterno.Name = "ApePaterno";
            ApePaterno.ReadOnly = true;
            // 
            // ApeMaterno
            // 
            ApeMaterno.DataPropertyName = "ApeMaterno";
            ApeMaterno.HeaderText = "ApeMaterno";
            ApeMaterno.MinimumWidth = 6;
            ApeMaterno.Name = "ApeMaterno";
            ApeMaterno.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Tel_cli";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Dir_cli";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "Dni_cli";
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Nacimiento
            // 
            Nacimiento.DataPropertyName = "Fec_nac";
            Nacimiento.HeaderText = "Nacimiento";
            Nacimiento.MinimumWidth = 6;
            Nacimiento.Name = "Nacimiento";
            Nacimiento.ReadOnly = true;
            // 
            // SexoTexto
            // 
            SexoTexto.DataPropertyName = "SexoTexto";
            SexoTexto.HeaderText = "Género";
            SexoTexto.MinimumWidth = 6;
            SexoTexto.Name = "SexoTexto";
            SexoTexto.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.MinimumWidth = 6;
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.MinimumWidth = 6;
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // EstadoTexto
            // 
            EstadoTexto.DataPropertyName = "EstadoTexto";
            EstadoTexto.HeaderText = "Estado";
            EstadoTexto.MinimumWidth = 6;
            EstadoTexto.Name = "EstadoTexto";
            EstadoTexto.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 634);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(120, 620);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(72, 34);
            lblRegistros.TabIndex = 12;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Location = new Point(825, 643);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(101, 36);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.Location = new Point(935, 643);
            btnActualizar.Margin = new Padding(5, 4, 5, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 36);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(1154, 643);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 36);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(1045, 643);
            btnEliminar.Margin = new Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 36);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 17;
            label2.Text = "Búsqueda por apellidos:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(202, 17);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(225, 27);
            txtFiltro.TabIndex = 18;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // ClienteMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 695);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Cliente";
            Load += ClienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCliente;
        private Label label1;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn ApePaterno;
        private DataGridViewTextBoxColumn ApeMaterno;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nacimiento;
        private DataGridViewTextBoxColumn SexoTexto;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn EstadoTexto;
        private Label label2;
        private TextBox txtFiltro;
    }
}