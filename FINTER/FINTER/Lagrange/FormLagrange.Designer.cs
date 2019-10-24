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
            this.SuspendLayout();
            // 
            // PolinomioResultante
            // 
            this.PolinomioResultante.AutoSize = true;
            this.PolinomioResultante.Location = new System.Drawing.Point(92, 23);
            this.PolinomioResultante.Name = "PolinomioResultante";
            this.PolinomioResultante.Size = new System.Drawing.Size(106, 13);
            this.PolinomioResultante.TabIndex = 0;
            this.PolinomioResultante.Text = "Polinomio Resultante";
            this.PolinomioResultante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MostrarPasos
            // 
            this.MostrarPasos.Location = new System.Drawing.Point(86, 62);
            this.MostrarPasos.Name = "MostrarPasos";
            this.MostrarPasos.Size = new System.Drawing.Size(112, 23);
            this.MostrarPasos.TabIndex = 1;
            this.MostrarPasos.Text = "Mostrar Pasos";
            this.MostrarPasos.UseVisualStyleBackColor = true;
            this.MostrarPasos.Click += new System.EventHandler(this.MostrarPasos_Click);
            // 
            // FormLagrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}