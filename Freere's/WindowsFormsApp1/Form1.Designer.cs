namespace WindowsFormsApp1
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
            this.btCargar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabControlClientes = new System.Windows.Forms.TabPage();
            this.btBuscar1 = new System.Windows.Forms.Button();
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.tabControlTurnos = new System.Windows.Forms.TabPage();
            this.btEliminarTurno = new System.Windows.Forms.Button();
            this.btModificarTurno = new System.Windows.Forms.Button();
            this.btCargaTurno = new System.Windows.Forms.Button();
            this.comboBoxClienteYTurno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBuscarTurnos = new System.Windows.Forms.TextBox();
            this.btBuscar2 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBarbero = new System.Windows.Forms.ComboBox();
            this.checkBoxPay = new System.Windows.Forms.CheckBox();
            this.texboxhora = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabControlTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btCargar
            // 
            this.btCargar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCargar.ForeColor = System.Drawing.Color.Red;
            this.btCargar.Location = new System.Drawing.Point(367, 278);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(167, 51);
            this.btCargar.TabIndex = 0;
            this.btCargar.Text = " ↑ ↑ ↑ C A R G A R ↑ ↑ ↑";
            this.btCargar.UseVisualStyleBackColor = false;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btModificar.ForeColor = System.Drawing.Color.Red;
            this.btModificar.Location = new System.Drawing.Point(540, 278);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(167, 51);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "§ § § M O D I F I C A R § § §";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btEliminar.ForeColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(713, 278);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(223, 51);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "x x x E L I M I N A R x x x\r\n";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(3, 24);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(849, 188);
            this.dgvCliente.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabControlClientes);
            this.tabControl.Controls.Add(this.tabControlTurnos);
            this.tabControl.Location = new System.Drawing.Point(858, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 361);
            this.tabControl.TabIndex = 8;
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.btBuscar1);
            this.tabControlClientes.Controls.Add(this.textBoxBuscarCliente);
            this.tabControlClientes.Controls.Add(this.txtCodigo);
            this.tabControlClientes.Controls.Add(this.label1);
            this.tabControlClientes.Controls.Add(this.btEliminar);
            this.tabControlClientes.Controls.Add(this.txtNombre);
            this.tabControlClientes.Controls.Add(this.btCargar);
            this.tabControlClientes.Controls.Add(this.btModificar);
            this.tabControlClientes.Controls.Add(this.label2);
            this.tabControlClientes.Location = new System.Drawing.Point(4, 22);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlClientes.Size = new System.Drawing.Size(942, 335);
            this.tabControlClientes.TabIndex = 0;
            this.tabControlClientes.Text = "Clientes";
            this.tabControlClientes.UseVisualStyleBackColor = true;
            this.tabControlClientes.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btBuscar1
            // 
            this.btBuscar1.Location = new System.Drawing.Point(775, 14);
            this.btBuscar1.Name = "btBuscar1";
            this.btBuscar1.Size = new System.Drawing.Size(75, 23);
            this.btBuscar1.TabIndex = 8;
            this.btBuscar1.Text = "Buscar";
            this.btBuscar1.UseVisualStyleBackColor = true;
            this.btBuscar1.Click += new System.EventHandler(this.btBuscar1_Click);
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(654, 14);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarCliente.TabIndex = 7;
            // 
            // tabControlTurnos
            // 
            this.tabControlTurnos.Controls.Add(this.btEliminarTurno);
            this.tabControlTurnos.Controls.Add(this.btModificarTurno);
            this.tabControlTurnos.Controls.Add(this.btCargaTurno);
            this.tabControlTurnos.Controls.Add(this.comboBoxClienteYTurno);
            this.tabControlTurnos.Controls.Add(this.label8);
            this.tabControlTurnos.Controls.Add(this.textBoxBuscarTurnos);
            this.tabControlTurnos.Controls.Add(this.btBuscar2);
            this.tabControlTurnos.Controls.Add(this.dateTimePicker);
            this.tabControlTurnos.Controls.Add(this.comboBarbero);
            this.tabControlTurnos.Controls.Add(this.checkBoxPay);
            this.tabControlTurnos.Controls.Add(this.texboxhora);
            this.tabControlTurnos.Controls.Add(this.textBoxDNI);
            this.tabControlTurnos.Controls.Add(this.label7);
            this.tabControlTurnos.Controls.Add(this.label6);
            this.tabControlTurnos.Controls.Add(this.label5);
            this.tabControlTurnos.Controls.Add(this.label4);
            this.tabControlTurnos.Controls.Add(this.label3);
            this.tabControlTurnos.Location = new System.Drawing.Point(4, 22);
            this.tabControlTurnos.Name = "tabControlTurnos";
            this.tabControlTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlTurnos.Size = new System.Drawing.Size(942, 335);
            this.tabControlTurnos.TabIndex = 1;
            this.tabControlTurnos.Text = "Turnos";
            this.tabControlTurnos.UseVisualStyleBackColor = true;
            // 
            // btEliminarTurno
            // 
            this.btEliminarTurno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btEliminarTurno.ForeColor = System.Drawing.Color.Red;
            this.btEliminarTurno.Location = new System.Drawing.Point(437, 278);
            this.btEliminarTurno.Name = "btEliminarTurno";
            this.btEliminarTurno.Size = new System.Drawing.Size(223, 51);
            this.btEliminarTurno.TabIndex = 20;
            this.btEliminarTurno.Text = "x x x E L I M I N A R x x x\r\n";
            this.btEliminarTurno.UseVisualStyleBackColor = false;
            this.btEliminarTurno.Click += new System.EventHandler(this.btEliminarTurno_Click);
            // 
            // btModificarTurno
            // 
            this.btModificarTurno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btModificarTurno.ForeColor = System.Drawing.Color.Red;
            this.btModificarTurno.Location = new System.Drawing.Point(264, 278);
            this.btModificarTurno.Name = "btModificarTurno";
            this.btModificarTurno.Size = new System.Drawing.Size(167, 51);
            this.btModificarTurno.TabIndex = 19;
            this.btModificarTurno.Text = "§ § § M O D I F I C A R § § §";
            this.btModificarTurno.UseVisualStyleBackColor = false;
            this.btModificarTurno.Click += new System.EventHandler(this.btModificarTurno_Click);
            // 
            // btCargaTurno
            // 
            this.btCargaTurno.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCargaTurno.ForeColor = System.Drawing.Color.Red;
            this.btCargaTurno.Location = new System.Drawing.Point(91, 278);
            this.btCargaTurno.Name = "btCargaTurno";
            this.btCargaTurno.Size = new System.Drawing.Size(167, 51);
            this.btCargaTurno.TabIndex = 18;
            this.btCargaTurno.Text = " ↑ ↑ ↑ C A R G A R ↑ ↑ ↑";
            this.btCargaTurno.UseVisualStyleBackColor = false;
            this.btCargaTurno.Click += new System.EventHandler(this.btCargaTurno_Click);
            // 
            // comboBoxClienteYTurno
            // 
            this.comboBoxClienteYTurno.FormattingEnabled = true;
            this.comboBoxClienteYTurno.Location = new System.Drawing.Point(124, 21);
            this.comboBoxClienteYTurno.Name = "comboBoxClienteYTurno";
            this.comboBoxClienteYTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClienteYTurno.TabIndex = 17;
            this.comboBoxClienteYTurno.SelectedIndexChanged += new System.EventHandler(this.comboBoxClienteYTurno_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "CLIENTE";
            // 
            // textBoxBuscarTurnos
            // 
            this.textBoxBuscarTurnos.Location = new System.Drawing.Point(634, 9);
            this.textBoxBuscarTurnos.Name = "textBoxBuscarTurnos";
            this.textBoxBuscarTurnos.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarTurnos.TabIndex = 14;
            // 
            // btBuscar2
            // 
            this.btBuscar2.Location = new System.Drawing.Point(778, 7);
            this.btBuscar2.Name = "btBuscar2";
            this.btBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btBuscar2.TabIndex = 13;
            this.btBuscar2.Text = "Buscar";
            this.btBuscar2.UseVisualStyleBackColor = true;
            this.btBuscar2.Click += new System.EventHandler(this.btBuscar2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(124, 107);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // comboBarbero
            // 
            this.comboBarbero.FormattingEnabled = true;
            this.comboBarbero.Items.AddRange(new object[] {
            "Dylan",
            "Daniel",
            "Don Omar",
            "Daddy Yankee",
            "Chris Martins"});
            this.comboBarbero.Location = new System.Drawing.Point(124, 222);
            this.comboBarbero.Name = "comboBarbero";
            this.comboBarbero.Size = new System.Drawing.Size(121, 21);
            this.comboBarbero.TabIndex = 11;
            // 
            // checkBoxPay
            // 
            this.checkBoxPay.AutoSize = true;
            this.checkBoxPay.Location = new System.Drawing.Point(124, 189);
            this.checkBoxPay.Name = "checkBoxPay";
            this.checkBoxPay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPay.TabIndex = 10;
            this.checkBoxPay.UseVisualStyleBackColor = true;
            // 
            // texboxhora
            // 
            this.texboxhora.Location = new System.Drawing.Point(124, 149);
            this.texboxhora.Name = "texboxhora";
            this.texboxhora.Size = new System.Drawing.Size(100, 20);
            this.texboxhora.TabIndex = 8;
            this.texboxhora.TextChanged += new System.EventHandler(this.texboxhora_TextChanged);
            this.texboxhora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texboxhora_KeyPress);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(124, 66);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 6;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "BARBERO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "PAGADO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "HORA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(94, 254);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(758, 182);
            this.dgvTurnos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1809, 587);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dgvCliente);
            this.Name = "Form1";
            this.Text = "F r e e r e \' s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControlClientes.ResumeLayout(false);
            this.tabControlClientes.PerformLayout();
            this.tabControlTurnos.ResumeLayout(false);
            this.tabControlTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabControlClientes;
        private System.Windows.Forms.TabPage tabControlTurnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxPay;
        private System.Windows.Forms.TextBox texboxhora;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBarbero;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btBuscar1;
        private System.Windows.Forms.TextBox textBoxBuscarCliente;
        private System.Windows.Forms.TextBox textBoxBuscarTurnos;
        private System.Windows.Forms.Button btBuscar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxClienteYTurno;
        private System.Windows.Forms.Button btEliminarTurno;
        private System.Windows.Forms.Button btModificarTurno;
        private System.Windows.Forms.Button btCargaTurno;
    }
}

