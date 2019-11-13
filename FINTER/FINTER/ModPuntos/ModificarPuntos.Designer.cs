namespace FINTER.ModificarPuntos
{
    partial class ModificarPuntos
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
            this.puntos = new System.Windows.Forms.RichTextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // puntos
            // 
            this.puntos.Location = new System.Drawing.Point(13, 13);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(167, 236);
            this.puntos.TabIndex = 0;
            this.puntos.Text = "";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(204, 13);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(109, 54);
            this.enviar.TabIndex = 1;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(204, 105);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(109, 54);
            this.atras.TabIndex = 2;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            // 
            // ModificarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.puntos);
            this.Name = "ModificarPuntos";
            this.Text = "ModificarPuntos";
            this.Load += new System.EventHandler(this.ModificarPuntos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox puntos;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button atras;

    }
}