namespace FINTER.Lagrange
{
    partial class FormLagrange
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
            this.PolinomioResultante = new System.Windows.Forms.Label();
            this.MostrarPasos = new System.Windows.Forms.Button();
            this.Especializador = new System.Windows.Forms.Button();
            this.ingresarK = new System.Windows.Forms.TextBox();
            this.Especializacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PolinomioResultante
            // 
            this.PolinomioResultante.AutoSize = true;
            this.PolinomioResultante.Location = new System.Drawing.Point(24, 23);
            this.PolinomioResultante.Name = "PolinomioResultante";
            this.PolinomioResultante.Size = new System.Drawing.Size(106, 13);
            this.PolinomioResultante.TabIndex = 0;
            this.PolinomioResultante.Text = "Polinomio Resultante";
            this.PolinomioResultante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PolinomioResultante.Click += new System.EventHandler(this.PolinomioResultante_Click);
            // 
            // MostrarPasos
            // 
            this.MostrarPasos.Location = new System.Drawing.Point(18, 62);
            this.MostrarPasos.Name = "MostrarPasos";
            this.MostrarPasos.Size = new System.Drawing.Size(112, 23);
            this.MostrarPasos.TabIndex = 1;
            this.MostrarPasos.Text = "Mostrar Pasos";
            this.MostrarPasos.UseVisualStyleBackColor = true;
            this.MostrarPasos.Click += new System.EventHandler(this.MostrarPasos_Click);
            // 
            // Especializador
            // 
            this.Especializador.Location = new System.Drawing.Point(189, 61);
            this.Especializador.Name = "Especializador";
            this.Especializador.Size = new System.Drawing.Size(84, 23);
            this.Especializador.TabIndex = 2;
            this.Especializador.Text = "Especializar K";
            this.Especializador.UseVisualStyleBackColor = true;
            this.Especializador.Click += new System.EventHandler(this.Especializador_Click);
            // 
            // ingresarK
            // 
            this.ingresarK.Location = new System.Drawing.Point(293, 63);
            this.ingresarK.Name = "ingresarK";
            this.ingresarK.Size = new System.Drawing.Size(73, 20);
            this.ingresarK.TabIndex = 3;
            // 
            // Especializacion
            // 
            this.Especializacion.AutoSize = true;
            this.Especializacion.Location = new System.Drawing.Point(387, 69);
            this.Especializacion.Name = "Especializacion";
            this.Especializacion.Size = new System.Drawing.Size(36, 13);
            this.Especializacion.TabIndex = 4;
            this.Especializacion.Text = "P(K) =";
            // 
            // FormLagrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.Especializacion);
            this.Controls.Add(this.ingresarK);
            this.Controls.Add(this.Especializador);
            this.Controls.Add(this.MostrarPasos);
            this.Controls.Add(this.PolinomioResultante);
            this.Name = "FormLagrange";
            this.Text = "Lagrange";
            this.Load += new System.EventHandler(this.FormLagrange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PolinomioResultante;
        private System.Windows.Forms.Button MostrarPasos;
        private System.Windows.Forms.Button Especializador;
        private System.Windows.Forms.TextBox ingresarK;
        private System.Windows.Forms.Label Especializacion;
    }
}