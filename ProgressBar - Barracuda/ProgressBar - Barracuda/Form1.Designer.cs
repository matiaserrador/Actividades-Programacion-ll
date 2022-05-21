namespace ProgressBar___Barracuda
{
    partial class Form1
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
            this.barra = new System.Windows.Forms.ProgressBar();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(12, 64);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(776, 24);
            this.barra.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Indigo;
            this.bt1.Location = new System.Drawing.Point(319, 242);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "B o t ó n";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgressBar___Barracuda.Properties.Resources.wallpapersden_com_purple_sunrise_4k_vaporwave_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.barra);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "B A R R A C U D A - D E - P R O G R E S O";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Button bt1;
    }
}

