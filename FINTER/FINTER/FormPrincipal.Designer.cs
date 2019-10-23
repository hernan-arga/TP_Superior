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
            this.lagrange = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.campoDeValores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lagrange
            // 
            this.lagrange.Location = new System.Drawing.Point(297, 70);
            this.lagrange.Name = "lagrange";
            this.lagrange.Size = new System.Drawing.Size(236, 44);
            this.lagrange.TabIndex = 0;
            this.lagrange.Text = "Lagrange";
            this.lagrange.UseVisualStyleBackColor = true;
            this.lagrange.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Newton Gregory Progresivo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Newton Gregory Regresivo";
            this.button3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoDeValores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lagrange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lagrange;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox campoDeValores;
        private System.Windows.Forms.Label label1;
    }
}

