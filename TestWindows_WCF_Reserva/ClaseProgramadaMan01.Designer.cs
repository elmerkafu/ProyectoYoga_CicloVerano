namespace TestWindows_WCF_Reserva
{
    partial class ClaseProgramadaMan01
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtgClaseProgramada = new DataGridView();
            Id_Clase_Prog = new DataGridViewTextBoxColumn();
            Id_Inst_Disp = new DataGridViewTextBoxColumn();
            NombreInstructor = new DataGridViewTextBoxColumn();
            NombreDisciplina = new DataGridViewTextBoxColumn();
            Intensidad = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Fec_Clase = new DataGridViewTextBoxColumn();
            Hora_Emp = new DataGridViewTextBoxColumn();
            Hora_Term = new DataGridViewTextBoxColumn();
            NombreSalon = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgClaseProgramada).BeginInit();
            SuspendLayout();
            // 
            // dtgClaseProgramada
            // 
            dtgClaseProgramada.AllowUserToAddRows = false;
            dtgClaseProgramada.AllowUserToDeleteRows = false;
            dtgClaseProgramada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgClaseProgramada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgClaseProgramada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClaseProgramada.Columns.AddRange(new DataGridViewColumn[] { Id_Clase_Prog, Id_Inst_Disp, NombreInstructor, NombreDisciplina, Intensidad, Duracion, Fec_Clase, Hora_Emp, Hora_Term, NombreSalon, Estado });
            dtgClaseProgramada.Location = new Point(12, 12);
            dtgClaseProgramada.Name = "dtgClaseProgramada";
            dtgClaseProgramada.ReadOnly = true;
            dtgClaseProgramada.RowHeadersVisible = false;
            dtgClaseProgramada.RowTemplate.Height = 25;
            dtgClaseProgramada.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClaseProgramada.Size = new Size(1140, 409);
            dtgClaseProgramada.TabIndex = 0;
            dtgClaseProgramada.DoubleClick += dtgClaseProgramada_DoubleClick;
            // 
            // Id_Clase_Prog
            // 
            Id_Clase_Prog.DataPropertyName = "Id_Clase_Prog";
            Id_Clase_Prog.FillWeight = 87.66498F;
            Id_Clase_Prog.HeaderText = "Código Clase";
            Id_Clase_Prog.Name = "Id_Clase_Prog";
            Id_Clase_Prog.ReadOnly = true;
            // 
            // Id_Inst_Disp
            // 
            Id_Inst_Disp.DataPropertyName = "Id_Inst_Disp";
            Id_Inst_Disp.FillWeight = 87.66498F;
            Id_Inst_Disp.HeaderText = "Cod. Instructor";
            Id_Inst_Disp.Name = "Id_Inst_Disp";
            Id_Inst_Disp.ReadOnly = true;
            // 
            // NombreInstructor
            // 
            NombreInstructor.DataPropertyName = "NombreInstructor";
            NombreInstructor.FillWeight = 223.350281F;
            NombreInstructor.HeaderText = "Instructor";
            NombreInstructor.Name = "NombreInstructor";
            NombreInstructor.ReadOnly = true;
            // 
            // NombreDisciplina
            // 
            NombreDisciplina.DataPropertyName = "NombreDisciplina";
            NombreDisciplina.FillWeight = 87.66498F;
            NombreDisciplina.HeaderText = "Disciplina";
            NombreDisciplina.Name = "NombreDisciplina";
            NombreDisciplina.ReadOnly = true;
            // 
            // Intensidad
            // 
            Intensidad.DataPropertyName = "Intensidad";
            Intensidad.FillWeight = 87.66498F;
            Intensidad.HeaderText = "Intensidad";
            Intensidad.Name = "Intensidad";
            Intensidad.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.FillWeight = 87.66498F;
            Duracion.HeaderText = "Duración";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // Fec_Clase
            // 
            Fec_Clase.DataPropertyName = "Fec_Clase";
            Fec_Clase.FillWeight = 87.66498F;
            Fec_Clase.HeaderText = "Fecha";
            Fec_Clase.Name = "Fec_Clase";
            Fec_Clase.ReadOnly = true;
            // 
            // Hora_Emp
            // 
            Hora_Emp.DataPropertyName = "Hora_Emp";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            Hora_Emp.DefaultCellStyle = dataGridViewCellStyle1;
            Hora_Emp.FillWeight = 87.66498F;
            Hora_Emp.HeaderText = "Hora Inicio";
            Hora_Emp.Name = "Hora_Emp";
            Hora_Emp.ReadOnly = true;
            // 
            // Hora_Term
            // 
            Hora_Term.DataPropertyName = "Hora_Term";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            Hora_Term.DefaultCellStyle = dataGridViewCellStyle2;
            Hora_Term.FillWeight = 87.66498F;
            Hora_Term.HeaderText = "Hora Fin";
            Hora_Term.Name = "Hora_Term";
            Hora_Term.ReadOnly = true;
            // 
            // NombreSalon
            // 
            NombreSalon.DataPropertyName = "NombreSalon";
            NombreSalon.FillWeight = 87.66498F;
            NombreSalon.HeaderText = "Salón";
            NombreSalon.Name = "NombreSalon";
            NombreSalon.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.FillWeight = 87.66498F;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 455);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(91, 454);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(63, 26);
            lblRegistros.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Location = new Point(830, 453);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 27);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(949, 453);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 27);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1064, 453);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ClaseProgramadaMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 494);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgClaseProgramada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClaseProgramadaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Clase";
            Load += ClaseProgramadaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgClaseProgramada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgClaseProgramada;
        private Label label1;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Id_Clase_Prog;
        private DataGridViewTextBoxColumn Id_Inst_Disp;
        private DataGridViewTextBoxColumn NombreInstructor;
        private DataGridViewTextBoxColumn NombreDisciplina;
        private DataGridViewTextBoxColumn Intensidad;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Fec_Clase;
        private DataGridViewTextBoxColumn Hora_Emp;
        private DataGridViewTextBoxColumn Hora_Term;
        private DataGridViewTextBoxColumn NombreSalon;
        private DataGridViewTextBoxColumn Estado;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnCancelar;
    }
}