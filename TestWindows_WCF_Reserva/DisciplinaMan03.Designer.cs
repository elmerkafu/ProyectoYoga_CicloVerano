namespace TestWindows_WCF_Reserva
{
    partial class DisciplinaMan03
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
            label6 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            cboCategoria = new ComboBox();
            mskPrecio = new MaskedTextBox();
            txtIntensidad = new TextBox();
            txtDuracion = new TextBox();
            txtNombre = new TextBox();
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(cboCategoria);
            groupBox1.Controls.Add(mskPrecio);
            groupBox1.Controls.Add(txtIntensidad);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtNombre);
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
            groupBox1.Text = "Datos de Disciplina";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(129, 36);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 23);
            lblCodigo.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 42);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 10;
            label6.Text = "Cod. Disciplina:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(77, 345);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(88, 27);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(128, 255);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(227, 23);
            cboCategoria.TabIndex = 5;
            // 
            // mskPrecio
            // 
            mskPrecio.Location = new Point(128, 207);
            mskPrecio.Mask = "999";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(100, 23);
            mskPrecio.TabIndex = 4;
            mskPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIntensidad
            // 
            txtIntensidad.Location = new Point(128, 161);
            txtIntensidad.Name = "txtIntensidad";
            txtIntensidad.Size = new Size(227, 23);
            txtIntensidad.TabIndex = 3;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(128, 119);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(227, 23);
            txtDuracion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 258);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 215);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 170);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Intensidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 127);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Duración:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // DisciplinaMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 494);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisciplinaMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Disciplina";
            Load += DisciplinaMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtIntensidad;
        private TextBox txtDuracion;
        private MaskedTextBox mskPrecio;
        private ComboBox cboCategoria;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label6;
        private Label lblCodigo;
    }
}