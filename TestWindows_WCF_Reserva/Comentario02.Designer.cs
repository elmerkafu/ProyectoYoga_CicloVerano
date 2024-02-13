namespace TestWindows_WCF_Reserva
{
    partial class Comentario02
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtComentario = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(112, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 24);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 103);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 24);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un comentario:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(35, 61);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(382, 23);
            txtComentario.TabIndex = 3;
            // 
            // Comentario02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 161);
            Controls.Add(txtComentario);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Comentario02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comentario02";
            Load += Comentario02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtComentario;
    }
}