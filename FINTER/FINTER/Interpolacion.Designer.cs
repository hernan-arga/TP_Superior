namespace FINTER
{
    partial class Interpolacion
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
            this.modificar = new System.Windows.Forms.Button();
            this.Especializacion = new System.Windows.Forms.Label();
            this.ingresarK = new System.Windows.Forms.TextBox();
            this.Especializador = new System.Windows.Forms.Button();
            this.MostrarPasos = new System.Windows.Forms.Button();
            this.PolinomioResultante = new System.Windows.Forms.Label();
            this.resultModif = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.equidistantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(33, 85);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(112, 23);
            this.modificar.TabIndex = 11;
            this.modificar.Text = "Modificar Puntos";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click_1);
            // 
            // Especializacion
            // 
            this.Especializacion.AutoSize = true;
            this.Especializacion.Location = new System.Drawing.Point(402, 115);
            this.Especializacion.Name = "Especializacion";
            this.Especializacion.Size = new System.Drawing.Size(36, 13);
            this.Especializacion.TabIndex = 10;
            this.Especializacion.Text = "P(K) =";
            // 
            // ingresarK
            // 
            this.ingresarK.Location = new System.Drawing.Point(308, 109);
            this.ingresarK.Name = "ingresarK";
            this.ingresarK.Size = new System.Drawing.Size(73, 20);
            this.ingresarK.TabIndex = 9;
            // 
            // Especializador
            // 
            this.Especializador.Location = new System.Drawing.Point(204, 107);
            this.Especializador.Name = "Especializador";
            this.Especializador.Size = new System.Drawing.Size(84, 23);
            this.Especializador.TabIndex = 8;
            this.Especializador.Text = "Especializar K";
            this.Especializador.UseVisualStyleBackColor = true;
            this.Especializador.Click += new System.EventHandler(this.Especializador_Click_1);
            // 
            // MostrarPasos
            // 
            this.MostrarPasos.Location = new System.Drawing.Point(33, 108);
            this.MostrarPasos.Name = "MostrarPasos";
            this.MostrarPasos.Size = new System.Drawing.Size(112, 23);
            this.MostrarPasos.TabIndex = 7;
            this.MostrarPasos.Text = "Mostrar Pasos";
            this.MostrarPasos.UseVisualStyleBackColor = true;
            this.MostrarPasos.Click += new System.EventHandler(this.MostrarPasos_Click_1);
            // 
            // PolinomioResultante
            // 
            this.PolinomioResultante.AutoSize = true;
            this.PolinomioResultante.Location = new System.Drawing.Point(39, 69);
            this.PolinomioResultante.Name = "PolinomioResultante";
            this.PolinomioResultante.Size = new System.Drawing.Size(106, 13);
            this.PolinomioResultante.TabIndex = 6;
            this.PolinomioResultante.Text = "Polinomio Resultante";
            this.PolinomioResultante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultModif
            // 
            this.resultModif.AutoSize = true;
            this.resultModif.Location = new System.Drawing.Point(33, 13);
            this.resultModif.Name = "resultModif";
            this.resultModif.Size = new System.Drawing.Size(55, 13);
            this.resultModif.TabIndex = 12;
            this.resultModif.Text = "Resultado";
            this.resultModif.Visible = false;
            
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(416, 8);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 23);
            this.Finalizar.TabIndex = 13;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // equidistantes
            // 
            this.equidistantes.AutoSize = true;
            this.equidistantes.Location = new System.Drawing.Point(33, 41);
            this.equidistantes.Name = "equidistantes";
            this.equidistantes.Size = new System.Drawing.Size(106, 13);
            this.equidistantes.TabIndex = 14;
            this.equidistantes.Text = "Puntos Equidistantes";
            this.equidistantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // Interpolacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 380);
            this.Controls.Add(this.equidistantes);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.resultModif);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.Especializacion);
            this.Controls.Add(this.ingresarK);
            this.Controls.Add(this.Especializador);
            this.Controls.Add(this.MostrarPasos);
            this.Controls.Add(this.PolinomioResultante);
            this.Name = "Interpolacion";
            this.Text = "Interpolacion";
            this.Load += new System.EventHandler(this.Interpolacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Label Especializacion;
        private System.Windows.Forms.TextBox ingresarK;
        private System.Windows.Forms.Button Especializador;
        private System.Windows.Forms.Button MostrarPasos;
        public System.Windows.Forms.Label PolinomioResultante;
        public System.Windows.Forms.Label resultModif;
        private System.Windows.Forms.Button Finalizar;
        public System.Windows.Forms.Label equidistantes;

    }
}