using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Pr0pAn0h
{
    public partial class FormPropano : Form
    {
        public FormPropano()
        {
            InitializeComponent();
            
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Width = 50;
            Height = 23;
        }

        private void btCarga1_Click(object sender, EventArgs e)
        {
            Producto NuevoProducto;
            NuevoProducto = new Producto(int.Parse(textBoxCodigo.Text), textBoxDesc.Text);
            lblCodigos.Text = NuevoProducto.codigo.ToString();
            lblDescripcion.Text = NuevoProducto.descripcion;
            lblStockA.Text = "Tenemos " + NuevoProducto.st0ck.ToString() + "en stock de este artículo";
            MessageBox.Show("Producto Cargado Exitosamente");

            DataGridView dgv = new DataGridView();


            DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
            colum.HeaderText = "Código";
            dgv.Columns.Add(colum);


            DataGridViewTextBoxColumn colum2 = new DataGridViewTextBoxColumn();
            colum2.HeaderText = "Descripción";
            dgv.Columns.Add(colum2);


            DataGridViewTextBoxColumn colum3 = new DataGridViewTextBoxColumn();
            colum3.HeaderText = "Stock";
            dgv.Columns.Add(colum3);

            int i = dgv.Rows.Add();
            dgv.Rows[i].Cells[0].Value = textBoxDesc.Text;
            dgv.Rows[i].Cells[1].Value = textBoxCodigo.Text;
            dgv.Rows[i].Cells[2].Value = textBoxStock.Text;
            tabControl1.SelectedIndex = 1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
