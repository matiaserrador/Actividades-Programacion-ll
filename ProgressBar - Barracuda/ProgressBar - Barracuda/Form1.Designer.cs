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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(12, 64);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(776, 24);
            this.barra.TabIndex = 0;
            this.barra.Click += new System.EventHandler(this.barra_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Indigo;
            this.bt1.Location = new System.Drawing.Point(69, 241);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(201, 57);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "B o t ó n  D e  A r r a n q u e";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(526, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "R e i n i c i o !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgressBar___Barracuda.Properties.Resources.wallpapersden_com_purple_sunrise_4k_vaporwave_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.barra);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "B A R R A C U D A - D E - P R O G R E S O";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

