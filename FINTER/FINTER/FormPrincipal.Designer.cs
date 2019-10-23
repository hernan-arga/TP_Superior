namespace FINTER
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lagrange = new System.Windows.Forms.Button();
            this.NGProgresivo = new System.Windows.Forms.Button();
            this.NGRegresivo = new System.Windows.Forms.Button();
            this.campoDeValores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lagrange
            // 
            this.Lagrange.Location = new System.Drawing.Point(297, 70);
            this.Lagrange.Name = "Lagrange";
            this.Lagrange.Size = new System.Drawing.Size(236, 44);
            this.Lagrange.TabIndex = 0;
            this.Lagrange.Text = "Lagrange";
            this.Lagrange.UseVisualStyleBackColor = true;
            this.Lagrange.Click += new System.EventHandler(this.Lagrange_Click);
            // 
            // NGProgresivo
            // 
            this.NGProgresivo.Location = new System.Drawing.Point(296, 128);
            this.NGProgresivo.Name = "NGProgresivo";
            this.NGProgresivo.Size = new System.Drawing.Size(237, 44);
            this.NGProgresivo.TabIndex = 1;
            this.NGProgresivo.Text = "Newton Gregory Progresivo";
            this.NGProgresivo.UseVisualStyleBackColor = true;
            this.NGProgresivo.Click += new System.EventHandler(this.NGProgresivo_Click);
            // 
            // NGRegresivo
            // 
            this.NGRegresivo.Location = new System.Drawing.Point(297, 188);
            this.NGRegresivo.Name = "NGRegresivo";
            this.NGRegresivo.Size = new System.Drawing.Size(236, 44);
            this.NGRegresivo.TabIndex = 2;
            this.NGRegresivo.Text = "Newton Gregory Regresivo";
            this.NGRegresivo.UseVisualStyleBackColor = true;
            this.NGRegresivo.Click += new System.EventHandler(this.NGRegresivo_Click);
            // 
            // campoDeValores
            // 
            this.campoDeValores.Location = new System.Drawing.Point(74, 58);
            this.campoDeValores.Multiline = true;
            this.campoDeValores.Name = "campoDeValores";
            this.campoDeValores.Size = new System.Drawing.Size(154, 196);
            this.campoDeValores.TabIndex = 3;
            this.campoDeValores.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los valores";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoDeValores);
            this.Controls.Add(this.NGRegresivo);
            this.Controls.Add(this.NGProgresivo);
            this.Controls.Add(this.Lagrange);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lagrange;
        private System.Windows.Forms.Button NGProgresivo;
        private System.Windows.Forms.Button NGRegresivo;
        private System.Windows.Forms.TextBox campoDeValores;
        private System.Windows.Forms.Label label1;
    }
}

