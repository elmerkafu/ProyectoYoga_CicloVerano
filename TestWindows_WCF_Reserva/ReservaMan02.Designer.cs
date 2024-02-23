namespace TestWindows_WCF_Reserva
{
    partial class ReservaMan02
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
            dtgClienteReserva = new DataGridView();
            Cod_resv = new DataGridViewTextBoxColumn();
            Fec_Clase = new DataGridViewTextBoxColumn();
            Hora_Emp = new DataGridViewTextBoxColumn();
            Hora_Term = new DataGridViewTextBoxColumn();
            NombreInstructor = new DataGridViewTextBoxColumn();
            Disciplina = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Intensidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgClienteReserva).BeginInit();
            SuspendLayout();
            // 
            // dtgClienteReserva
            // 
            dtgClienteReserva.AllowUserToAddRows = false;
            dtgClienteReserva.AllowUserToDeleteRows = false;
            dtgClienteReserva.ColumnHeadersHeight = 30;
            dtgClienteReserva.Columns.AddRange(new DataGridViewColumn[] { Cod_resv, Fec_Clase, Hora_Emp, Hora_Term, NombreInstructor, Disciplina, Duracion, Intensidad });
            dtgClienteReserva.Location = new Point(12, 32);
            dtgClienteReserva.Name = "dtgClienteReserva";
            dtgClienteReserva.RowHeadersVisible = false;
            dtgClienteReserva.RowTemplate.Height = 25;
            dtgClienteReserva.Size = new Size(882, 373);
            dtgClienteReserva.TabIndex = 0;
            // 
            // Cod_resv
            // 
            Cod_resv.DataPropertyName = "Cod_resv";
            Cod_resv.HeaderText = "Cod. Rev";
            Cod_resv.Name = "Cod_resv";
            // 
            // Fec_Clase
            // 
            Fec_Clase.DataPropertyName = "Fec_Clase";
            Fec_Clase.HeaderText = "Fecha Clase";
            Fec_Clase.Name = "Fec_Clase";
            // 
            // Hora_Emp
            // 
            Hora_Emp.DataPropertyName = "Hora_Emp";
            Hora_Emp.HeaderText = "Hora Inicio";
            Hora_Emp.Name = "Hora_Emp";
            // 
            // Hora_Term
            // 
            Hora_Term.DataPropertyName = "Hora_Term";
            Hora_Term.HeaderText = "Hora Fin";
            Hora_Term.Name = "Hora_Term";
            // 
            // NombreInstructor
            // 
            NombreInstructor.DataPropertyName = "NombreInstructor";
            NombreInstructor.FillWeight = 120F;
            NombreInstructor.HeaderText = "Nombre del Instructor";
            NombreInstructor.Name = "NombreInstructor";
            NombreInstructor.Width = 180;
            // 
            // Disciplina
            // 
            Disciplina.DataPropertyName = "Disciplina";
            Disciplina.HeaderText = "Disciplina";
            Disciplina.Name = "Disciplina";
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duración";
            Duracion.Name = "Duracion";
            // 
            // Intensidad
            // 
            Intensidad.DataPropertyName = "Intensidad";
            Intensidad.HeaderText = "Intensidad";
            Intensidad.Name = "Intensidad";
            // 
            // ReservaMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 420);
            Controls.Add(dtgClienteReserva);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservaMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Reservas";
            Load += ReservaMan02_Load;
            ((System.ComponentModel.ISupportInitialize)dtgClienteReserva).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgClienteReserva;
        private DataGridViewTextBoxColumn Cod_resv;
        private DataGridViewTextBoxColumn Fec_Clase;
        private DataGridViewTextBoxColumn Hora_Emp;
        private DataGridViewTextBoxColumn Hora_Term;
        private DataGridViewTextBoxColumn NombreInstructor;
        private DataGridViewTextBoxColumn Disciplina;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Intensidad;
    }
}