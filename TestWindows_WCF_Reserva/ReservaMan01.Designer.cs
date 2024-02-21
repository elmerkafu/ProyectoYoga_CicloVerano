namespace TestWindows_WCF_Reserva
{
    partial class ReservaMan01
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
            label5 = new Label();
            lblIdCli = new Label();
            lblNombre = new Label();
            lblApePa = new Label();
            lblApaMa = new Label();
            mskDNI = new MaskedTextBox();
            btnBuscar = new Button();
            monthCalendar1 = new MonthCalendar();
            btnCapturarFec = new Button();
            label6 = new Label();
            dtgClasesReserva = new DataGridView();
            Id_Clase_Prog = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            NombreInstructor = new DataGridViewTextBoxColumn();
            Fec_Clase = new DataGridViewTextBoxColumn();
            Hora_Emp = new DataGridViewTextBoxColumn();
            Hora_Term = new DataGridViewTextBoxColumn();
            Est_clase = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            Reservar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtgClasesReserva).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese DNI del cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Cod. Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 183);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 237);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido Materno:";
            // 
            // lblIdCli
            // 
            lblIdCli.BorderStyle = BorderStyle.FixedSingle;
            lblIdCli.Location = new Point(188, 79);
            lblIdCli.Name = "lblIdCli";
            lblIdCli.Size = new Size(188, 23);
            lblIdCli.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(188, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(188, 23);
            lblNombre.TabIndex = 7;
            // 
            // lblApePa
            // 
            lblApePa.BorderStyle = BorderStyle.FixedSingle;
            lblApePa.Location = new Point(188, 175);
            lblApePa.Name = "lblApePa";
            lblApePa.Size = new Size(188, 23);
            lblApePa.TabIndex = 8;
            // 
            // lblApaMa
            // 
            lblApaMa.BorderStyle = BorderStyle.FixedSingle;
            lblApaMa.Location = new Point(188, 229);
            lblApaMa.Name = "lblApaMa";
            lblApaMa.Size = new Size(188, 23);
            lblApaMa.TabIndex = 9;
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(206, 30);
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(100, 23);
            mskDNI.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(353, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(516, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // btnCapturarFec
            // 
            btnCapturarFec.Location = new Point(516, 229);
            btnCapturarFec.Name = "btnCapturarFec";
            btnCapturarFec.Size = new Size(192, 23);
            btnCapturarFec.TabIndex = 13;
            btnCapturarFec.Text = "Buscar";
            btnCapturarFec.UseVisualStyleBackColor = true;
            btnCapturarFec.Click += btnCapturarFec_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 312);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 14;
            label6.Text = "Clases Programadas:";
            // 
            // dtgClasesReserva
            // 
            dtgClasesReserva.AllowUserToAddRows = false;
            dtgClasesReserva.AllowUserToDeleteRows = false;
            dtgClasesReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClasesReserva.Columns.AddRange(new DataGridViewColumn[] { Id_Clase_Prog, Nombre, NombreInstructor, Fec_Clase, Hora_Emp, Hora_Term, Est_clase, Capacidad, Reservar });
            dtgClasesReserva.Location = new Point(34, 348);
            dtgClasesReserva.Name = "dtgClasesReserva";
            dtgClasesReserva.ReadOnly = true;
            dtgClasesReserva.RowHeadersVisible = false;
            dtgClasesReserva.RowTemplate.Height = 25;
            dtgClasesReserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClasesReserva.Size = new Size(903, 341);
            dtgClasesReserva.TabIndex = 15;
            dtgClasesReserva.CellContentClick += dtgClasesReserva_CellContentClick;
            // 
            // Id_Clase_Prog
            // 
            Id_Clase_Prog.DataPropertyName = "Id_Clase_Prog";
            Id_Clase_Prog.HeaderText = "Cod. Clase";
            Id_Clase_Prog.Name = "Id_Clase_Prog";
            Id_Clase_Prog.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Salon";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // NombreInstructor
            // 
            NombreInstructor.DataPropertyName = "NombreInstructor";
            NombreInstructor.HeaderText = "Nombre del Instructor";
            NombreInstructor.Name = "NombreInstructor";
            NombreInstructor.ReadOnly = true;
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
            Hora_Emp.HeaderText = "Hora Inicio";
            Hora_Emp.Name = "Hora_Emp";
            Hora_Emp.ReadOnly = true;
            // 
            // Hora_Term
            // 
            Hora_Term.DataPropertyName = "Hora_Term";
            Hora_Term.HeaderText = "Hora Fin";
            Hora_Term.Name = "Hora_Term";
            Hora_Term.ReadOnly = true;
            // 
            // Est_clase
            // 
            Est_clase.DataPropertyName = "Est_clase";
            Est_clase.HeaderText = "Estado";
            Est_clase.Name = "Est_clase";
            Est_clase.ReadOnly = true;
            // 
            // Capacidad
            // 
            Capacidad.DataPropertyName = "Capacidad";
            Capacidad.HeaderText = "Capacidad";
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            // 
            // Reservar
            // 
            Reservar.HeaderText = "Reservar";
            Reservar.Name = "Reservar";
            Reservar.ReadOnly = true;
            // 
            // ReservaMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 748);
            Controls.Add(dtgClasesReserva);
            Controls.Add(label6);
            Controls.Add(btnCapturarFec);
            Controls.Add(monthCalendar1);
            Controls.Add(btnBuscar);
            Controls.Add(mskDNI);
            Controls.Add(lblApaMa);
            Controls.Add(lblApePa);
            Controls.Add(lblNombre);
            Controls.Add(lblIdCli);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReservaMan01";
            Text = "ReservaMan01";
            Load += ReservaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgClasesReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblIdCli;
        private Label lblNombre;
        private Label lblApePa;
        private Label lblApaMa;
        private MaskedTextBox mskDNI;
        private Button btnBuscar;
        private MonthCalendar monthCalendar1;
        private Button btnCapturarFec;
        private Label label6;
        private DataGridView dtgClasesReserva;
        private DataGridViewTextBoxColumn Id_Clase_Prog;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NombreInstructor;
        private DataGridViewTextBoxColumn Fec_Clase;
        private DataGridViewTextBoxColumn Hora_Emp;
        private DataGridViewTextBoxColumn Hora_Term;
        private DataGridViewTextBoxColumn Est_clase;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewButtonColumn Reservar;
    }
}