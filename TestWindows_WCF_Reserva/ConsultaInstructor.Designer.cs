namespace TestWindows_WCF_Reserva
{
    partial class ConsultaInstructor
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgConsulta = new DataGridView();
            txtCod = new TextBox();
            label1 = new Label();
            dtpIni = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnConsultar = new Button();
            label4 = new Label();
            btnBuscarCod = new Button();
            lblNombreCompleto = new Label();
            NombreSalon = new DataGridViewTextBoxColumn();
            NombreDisciplina = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Intensidad = new DataGridViewTextBoxColumn();
            Fec_Clase = new DataGridViewTextBoxColumn();
            Hora_Emp = new DataGridViewTextBoxColumn();
            Hora_Term = new DataGridViewTextBoxColumn();
            EstadoClase = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgConsulta).BeginInit();
            SuspendLayout();
            // 
            // dtgConsulta
            // 
            dtgConsulta.AllowUserToAddRows = false;
            dtgConsulta.AllowUserToDeleteRows = false;
            dtgConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgConsulta.Columns.AddRange(new DataGridViewColumn[] { NombreSalon, NombreDisciplina, Duracion, Intensidad, Fec_Clase, Hora_Emp, Hora_Term, EstadoClase });
            dtgConsulta.Location = new Point(12, 273);
            dtgConsulta.Name = "dtgConsulta";
            dtgConsulta.ReadOnly = true;
            dtgConsulta.RowHeadersVisible = false;
            dtgConsulta.RowTemplate.Height = 25;
            dtgConsulta.Size = new Size(803, 277);
            dtgConsulta.TabIndex = 0;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(161, 33);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(86, 23);
            txtCod.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese su código:";
            // 
            // dtpIni
            // 
            dtpIni.Format = DateTimePickerFormat.Short;
            dtpIni.Location = new Point(33, 175);
            dtpIni.MinDate = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            dtpIni.Name = "dtpIni";
            dtpIni.Size = new Size(121, 23);
            dtpIni.TabIndex = 3;
            dtpIni.Value = new DateTime(2024, 3, 1, 18, 4, 51, 0);
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(260, 175);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(121, 23);
            dtpFin.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 143);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 143);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha Fin:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(32, 225);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(96, 27);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 93);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Instructor:";
            // 
            // btnBuscarCod
            // 
            btnBuscarCod.Location = new Point(302, 33);
            btnBuscarCod.Name = "btnBuscarCod";
            btnBuscarCod.Size = new Size(90, 24);
            btnBuscarCod.TabIndex = 11;
            btnBuscarCod.Text = "Buscar";
            btnBuscarCod.UseVisualStyleBackColor = true;
            btnBuscarCod.Click += btnBuscarCod_Click;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCompleto.Location = new Point(121, 91);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(241, 26);
            lblNombreCompleto.TabIndex = 12;
            // 
            // NombreSalon
            // 
            NombreSalon.DataPropertyName = "NombreSalon";
            NombreSalon.HeaderText = "Salón";
            NombreSalon.Name = "NombreSalon";
            NombreSalon.ReadOnly = true;
            // 
            // NombreDisciplina
            // 
            NombreDisciplina.DataPropertyName = "NombreDisciplina";
            NombreDisciplina.HeaderText = "Disciplina";
            NombreDisciplina.Name = "NombreDisciplina";
            NombreDisciplina.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
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
            // Fec_Clase
            // 
            Fec_Clase.DataPropertyName = "Fec_Clase";
            Fec_Clase.HeaderText = "Fecha Clase";
            Fec_Clase.Name = "Fec_Clase";
            Fec_Clase.ReadOnly = true;
            // 
            // Hora_Emp
            // 
            Hora_Emp.DataPropertyName = "Hora_Emp";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            Hora_Emp.DefaultCellStyle = dataGridViewCellStyle3;
            Hora_Emp.HeaderText = "Hora Inicio";
            Hora_Emp.Name = "Hora_Emp";
            Hora_Emp.ReadOnly = true;
            // 
            // Hora_Term
            // 
            Hora_Term.DataPropertyName = "Hora_Term";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            Hora_Term.DefaultCellStyle = dataGridViewCellStyle4;
            Hora_Term.HeaderText = "Hora Fin";
            Hora_Term.Name = "Hora_Term";
            Hora_Term.ReadOnly = true;
            // 
            // EstadoClase
            // 
            EstadoClase.DataPropertyName = "EstadoClase";
            EstadoClase.HeaderText = "Estado";
            EstadoClase.Name = "EstadoClase";
            EstadoClase.ReadOnly = true;
            // 
            // ConsultaInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 568);
            Controls.Add(lblNombreCompleto);
            Controls.Add(btnBuscarCod);
            Controls.Add(label4);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFin);
            Controls.Add(dtpIni);
            Controls.Add(label1);
            Controls.Add(txtCod);
            Controls.Add(dtgConsulta);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultaInstructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Instructor";
            Load += ConsultaInstructor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgConsulta;
        private TextBox txtCod;
        private Label label1;
        private DateTimePicker dtpIni;
        private DateTimePicker dtpFin;
        private Label label2;
        private Label label3;
        private Button btnConsultar;
        private Label label4;
        private Button btnBuscarCod;
        private Label lblNombreCompleto;
        private DataGridViewTextBoxColumn NombreSalon;
        private DataGridViewTextBoxColumn NombreDisciplina;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Intensidad;
        private DataGridViewTextBoxColumn Fec_Clase;
        private DataGridViewTextBoxColumn Hora_Emp;
        private DataGridViewTextBoxColumn Hora_Term;
        private DataGridViewTextBoxColumn EstadoClase;
    }
}