namespace TestWindows_WCF_Reserva
{
    partial class ClaseProgramadaMan03
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
            groupBox1 = new GroupBox();
            lblCodigo = new Label();
            label8 = new Label();
            chkEstado = new CheckBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraIni = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            cboSalon = new ComboBox();
            cboDisciplina = new ComboBox();
            cboInstructor = new ComboBox();
            btnGrabar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(dtpHoraFin);
            groupBox1.Controls.Add(dtpHoraIni);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(cboSalon);
            groupBox1.Controls.Add(cboDisciplina);
            groupBox1.Controls.Add(cboInstructor);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 470);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Clase ";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(117, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 23);
            lblCodigo.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 42);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 16;
            label8.Text = "Cod. Clase:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(121, 362);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 15;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(117, 302);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(103, 23);
            dtpHoraFin.TabIndex = 14;
            // 
            // dtpHoraIni
            // 
            dtpHoraIni.Format = DateTimePickerFormat.Time;
            dtpHoraIni.Location = new Point(117, 257);
            dtpHoraIni.Name = "dtpHoraIni";
            dtpHoraIni.Size = new Size(103, 23);
            dtpHoraIni.TabIndex = 13;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(117, 208);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(103, 23);
            dtpFecha.TabIndex = 12;
            // 
            // cboSalon
            // 
            cboSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalon.DropDownWidth = 256;
            cboSalon.FormattingEnabled = true;
            cboSalon.Location = new Point(117, 166);
            cboSalon.Name = "cboSalon";
            cboSalon.Size = new Size(227, 23);
            cboSalon.TabIndex = 11;
            // 
            // cboDisciplina
            // 
            cboDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDisciplina.FormattingEnabled = true;
            cboDisciplina.Location = new Point(117, 123);
            cboDisciplina.Name = "cboDisciplina";
            cboDisciplina.Size = new Size(227, 23);
            cboDisciplina.TabIndex = 10;
            // 
            // cboInstructor
            // 
            cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInstructor.FormattingEnabled = true;
            cboInstructor.Location = new Point(117, 81);
            cboInstructor.Name = "cboInstructor";
            cboInstructor.Size = new Size(227, 23);
            cboInstructor.TabIndex = 9;
            cboInstructor.SelectionChangeCommitted += cboInstructor_SelectionChangeCommitted;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(64, 426);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 363);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 308);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Hora Fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 257);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Hora Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 214);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 169);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Salón:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 126);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 84);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Instructor:";
            // 
            // ClaseProgramadaMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 494);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClaseProgramadaMan03";
            Text = "Actualizar Clase Programada";
            Load += ClaseProgramadaMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFecha;
        private ComboBox cboSalon;
        private ComboBox cboDisciplina;
        private ComboBox cboInstructor;
        private Button btnGrabar;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraIni;
        private CheckBox chkEstado;
        private Label lblCodigo;
        private Label label8;
    }
}