using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha
{
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();
        }
        Persona UnaPersona = new Persona();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            long Dni = int.Parse(textBoxDNI.Text);
            DateTime Fecha = DateTime.Parse(textBoxFechaNac.Text);
            persona = new Persona(nombre, Dni, Fecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            persona = new Persona();

            DateTime fecha = DateTime.Parse(textBoxFechaNac.Text);
            int año = fecha.Year;
            lblFechaEdad.Text = "FechaEdad: " + persona.FechaEdad(año).ToString();
        }
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxFechaNac_Validated(object sender, EventArgs e)
        {
            DateTime validacion = DateTime.Parse(textBoxFechaNac.Text);
            DateTime dt = DateTime.Now;
            if (validacion > dt)
            {
                MessageBox.Show("La fecha de nacimiento es invalida");
            }
        }
    }
}
