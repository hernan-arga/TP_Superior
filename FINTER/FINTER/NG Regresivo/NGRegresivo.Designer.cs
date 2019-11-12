namespace FINTER.NG_Regresivo
{
    partial class NGRegresivo
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
            this.mostrarPasos = new System.Windows.Forms.Button();
            this.PolinomioResultante = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrarPasos
            // 
            this.mostrarPasos.Location = new System.Drawing.Point(86, 165);
            this.mostrarPasos.Name = "mostrarPasos";
            this.mostrarPasos.Size = new System.Drawing.Size(112, 23);
            this.mostrarPasos.TabIndex = 3;
            this.mostrarPasos.Text = "Mostrar Pasos";
            this.mostrarPasos.UseVisualStyleBackColor = true;
            this.mostrarPasos.Click += new System.EventHandler(this.mostrarPasos_Click);
            // 
            // PolinomioResultante
            // 
            this.PolinomioResultante.AutoSize = true;
            this.PolinomioResultante.Location = new System.Drawing.Point(92, 73);
            this.PolinomioResultante.Name = "PolinomioResultante";
            this.PolinomioResultante.Size = new System.Drawing.Size(106, 13);
            this.PolinomioResultante.TabIndex = 2;
            this.PolinomioResultante.Text = "Polinomio Resultante";
            this.PolinomioResultante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PolinomioResultante.Click += new System.EventHandler(this.PolinomioResultante_Click);
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(255, 12);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(84, 23);
            this.Finalizar.TabIndex = 7;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            // 
            // NGRegresivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.mostrarPasos);
            this.Controls.Add(this.PolinomioResultante);
            this.Name = "NGRegresivo";
            this.Text = "NGRegresivo";
            this.Load += new System.EventHandler(this.NGRegresivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrarPasos;
        private System.Windows.Forms.Label PolinomioResultante;
        private System.Windows.Forms.Button Finalizar;

    }
}