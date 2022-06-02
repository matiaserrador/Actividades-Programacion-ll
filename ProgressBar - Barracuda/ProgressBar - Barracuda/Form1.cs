using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar___Barracuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void bt1_Click(object sender, EventArgs e)
        {
            // Instancio el valor inicial de la barra 
            barra.Value = 0;

            //Instancia el valor máximo de la barra
            barra.Maximum = 100;

            //Instancio el valor Mininmo de la barra
            barra.Minimum = 0;

            //El "paso a paso" sera de uno en uno, dado este valor.
            barra.Step = 1;

            //Cargamos la barra
            //barra.Increment(1);
            
            for (int i = barra.Minimum; i < barra.Maximum; i = i + barra.Step)
            {
                //Esto hace que la barra vaya avanzando.
                barra.PerformStep();
                System.Threading.Thread.Sleep(500);
            }
            
            label1.Text=barra.Value.ToString();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barra.Value = 0;
            label1.Text = barra.Value.ToString();
        }

        private void barra_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
