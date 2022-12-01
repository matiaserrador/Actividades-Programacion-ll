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
using CapaNegocio;
using System.Globalization;
using CapaNegocio;
using Entidades;
using System.Globalization;
using System.Net.Http.Headers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvCliente.ColumnCount = 3;
            dgvCliente.Columns[0].HeaderText = "Id";
            dgvCliente.Columns[1].HeaderText = "Código";
            dgvCliente.Columns[2].HeaderText = "Nombre";
            dgvTurnos.ColumnCount = 7;
            
            dgvTurnos.Columns[0].HeaderText = "Id";
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].HeaderText = "Dni";
            dgvTurnos.Columns[2].HeaderText = "Fecha";
            dgvTurnos.Columns[3].HeaderText = "Hora";
            dgvTurnos.Columns[4].HeaderText = "Pagado";
            dgvTurnos.Columns[5].HeaderText = "Barbero";
            dgvTurnos.Columns[6].HeaderText = "Id Cliente";

            LlenarDGVClient();
            LlenarDGVTurnos();
            LlenarDGVTurnosBusqueda();
            LlenarDGVClientBusqueda();
            LlenarComboCliente();
        }

        #region Juanchin
        private void LlenarComboCliente()
        {
            DataSet ds = new DataSet();
            ds = negoClientex.ListadoCliente("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<Clientes> listadoClientes = new List<Clientes>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listadoClientes.Add(new Clientes
                    {
                        ID = System.Convert.ToInt32(dr[0]),
                        NOMBRE = dr[2].ToString(),
                    });
                }
                comboBoxClienteYTurno.DataSource = listadoClientes;

                comboBoxClienteYTurno.DisplayMember = "NOMBRE";
                comboBoxClienteYTurno.ValueMember = "ID";
            }
        }
        #endregion

        #region Llenar los DataGrid
        private void LlenarDGVClient()
        {
            dgvCliente.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negoClientex.ListadoCliente("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCliente.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]); //dr[2].ToString() ASI ANTES
                }
            }

        }
        private void LlenarDGVTurnos()
        {
            dgvTurnos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negoTurnox.ListadoTurno("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvTurnos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3].ToString(), dr[4].ToString(), dr[5], dr[6].ToString()); //dr[1],dr[2].ToString(),dr[3],dr[5].ToString()
                }
            }
        }
        private void LlenarDGVTurnosBusqueda()
        {
            string cual = textBoxBuscarTurnos.Text;
            dgvTurnos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negoTurnox.ListadoTurnosBusqueda(cual);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvTurnos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3].ToString(), dr[4].ToString(), dr[5], dr[6].ToString());
                }
            }

        }
        private void LlenarDGVClientBusqueda()
        {
            string cual = textBoxBuscarCliente.Text;
            dgvCliente.Rows.Clear();
            DataSet ds = new DataSet();
            ds = negoClientex.ListadoClientesBusqueda(cual);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCliente.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]);
                }
            }
        }
        #endregion

        #region Variabless
        public Clientes objClientex = new Clientes();
        public Turnos objTurnox=new Turnos();
        public NegoCliente negoClientex=new NegoCliente();
        public NegoTurno negoTurnox=new NegoTurno();
        #endregion

        #region Datos a los Text Box
        private void DatosALosTextBoxClientes()
        {
            objClientex.CodCliente = int.Parse(txtCodigo.Text);
            objClientex.NOMBRE = txtNombre.Text;
        }
        private void DatosALosTextBoxTurnos()
        {
            objTurnox.IDCLIENTE = int.Parse(comboBoxClienteYTurno.SelectedValue.ToString());
            objTurnox.DNI = int.Parse(textBoxDNI.Text);
            objTurnox.FECHA = dateTimePicker.Value.ToString();
            objTurnox.HORA = int.Parse(texboxhora.Text);
            bool Pagado = checkBoxPay.Checked;
            objTurnox.PagadoPagado(Pagado);
            objTurnox.BARBERO = comboBarbero.SelectedItem.ToString();
        }

        #endregion
        //Chekear el texboxhora.//Chekear el texboxhora.//Chekear el texboxhora.
        #region Cartelitos si NO se ingresaron los Datos
        public bool CartelitosSiNo()
        {
            ///Código
            if (txtCodigo.Text==string.Empty)
            {
                MessageBox.Show("Por favor, ingrese su código" , "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtCodigo.Text.Length > 10 || txtCodigo.Text.Length < 4)
            {
                MessageBox.Show("Sólo se permiten códigos entre 4 y 10 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ///Nombre
            if (txtNombre.Text== string.Empty)
            {
                MessageBox.Show("Por favor, ingrese su Nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if  (txtNombre.Text.Length > 50 || txtNombre.Text.Length < 4)
            {
                MessageBox.Show("Sólo se permiten nombres entre 4 y 50 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        public bool CartelitosSiNo2()
        {
            ///DNI
            if (textBoxDNI.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese su DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBoxDNI.Text.Length > 10 || textBoxDNI.Text.Length < 7)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 10 digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ///HORA
            if (texboxhora.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese el horario del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.Parse(texboxhora.Text) > 22 || int.Parse(texboxhora.Text) < 15)
            {
                MessageBox.Show("Ingrese un horario valido. El horario de atención es de 15 a 22 hs!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
            return true;
        }
        #endregion

        #region Limpieza
        private void LimpiarCliente()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        private void LimpiarTurnos()
        {
            comboBoxClienteYTurno.SelectedIndex = 0;
            textBoxDNI.Text=String.Empty;
            dateTimePicker.Value = DateTime.Today;
            checkBoxPay.Checked = false;
            comboBarbero.SelectedIndex = 0;
        }
        #endregion

        #region Botón Cargar
        private void btCargar_Click(object sender, EventArgs e)
        {
            bool validacion = CartelitosSiNo();
            int nCargados = -1;
            if (validacion == true)
            {
                DatosALosTextBoxClientes();
                nCargados = negoClientex.abmClientes("Alta", objClientex);
                if (nCargados == -1)
                {
                    CartelitosSiNo();
                    MessageBox.Show("No se pudo agregar el cliente");
                }
                else
                {
                    MessageBox.Show("Se agregó al Cliente");
                    LlenarDGVClient();
                    LimpiarCliente();
                    LlenarComboCliente();
                }
            }
        }

        private void btCargaTurno_Click(object sender, EventArgs e)
        {
            bool validacion = CartelitosSiNo2();
            int nCargados = -1;
            if (validacion == true)
            {
                DatosALosTextBoxTurnos();
                nCargados = negoTurnox.abmTurnos("Alta", objTurnox);
                if (nCargados == -1)
                {
                    CartelitosSiNo2();
                    MessageBox.Show("No se pudo agregar el turno");
                }
                else
                {
                    MessageBox.Show("Se agregó el turno");
                    LlenarDGVTurnos();
                    LimpiarTurnos();
                }
            }
        }
        #endregion

        # region Botón Modificar
        private void btModificar_Click(object sender, EventArgs e)
        {
            bool validar = CartelitosSiNo();
            int nres = -1;
            if (validar==true)
            {
                int IdCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                objClientex.ID=IdCliente;
                DatosALosTextBoxClientes();
                nres = negoClientex.abmClientes("Modificar", objClientex);
                if (nres != -1)
                {
                    CartelitosSiNo();
                    MessageBox.Show("El cliente fue modificado con éxito");
                    LimpiarCliente();
                    LlenarDGVClient();
                    LlenarComboCliente();
                    //btModificar.Visible = false;
                    //btCargar.Visible = true;
                    //btEliminar.Visible = false;
                }
                else 
                {
                    MessageBox.Show("Error al modificar al cliente :C");
                }
            }
        }
        private void btModificarTurno_Click(object sender, EventArgs e)
        {
            bool validarr = CartelitosSiNo2();
            int resn = -1;
            if (validarr==true)
            {
                int IdCliente = Convert.ToInt32(dgvTurnos.CurrentRow.Cells[0].Value);
                objTurnox.ID = IdCliente;
                DatosALosTextBoxTurnos();
                resn = negoTurnox.abmTurnos("Modificar", objTurnox);
                if(resn!= -1)
                {
                    CartelitosSiNo2();
                    MessageBox.Show("El turno fue modificado con éxito");
                    LimpiarTurnos();
                    LlenarDGVTurnos();
                    //btModificarTurno.Visible = false;
                    //btCargaTurno.Visible = false;
                    //btEliminarTurno.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error al modificar Turno :C");
                }
            }
        }
        #endregion

        #region Botón Eliminar
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¡¿Estás seguro que quéres borrar al cliente?!" , "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int IdCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                objClientex.ID = IdCliente;
                int nGrabadosss = -1;
                nGrabadosss = negoClientex.abmClientes("Baja", objClientex);
                if (nGrabadosss == -1)
                {
                    MessageBox.Show("No se logró eliminar el cliente");
                }
                else
                {
                    MessageBox.Show("Se borró al cliente con éxito");
                    LlenarDGVClient();
                    LimpiarCliente();
                    LlenarComboCliente();
                    //btCargar.Visible = false;
                    //btModificar.Visible = false;
                    //btEliminar.Visible = false;
                }
            }
        }
        private void btEliminarTurno_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¡¿Estás seguro que quéres borrar el turno?!", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int IdCliente = Convert.ToInt32(dgvTurnos.CurrentRow.Cells[0].Value);
                objTurnox.ID = IdCliente;
                int nrg = -1;
                nrg = negoTurnox.abmTurnos("Baja", objTurnox);
                if (nrg == -1)
                {
                    MessageBox.Show("No se logro eliminar el turno");
                }
                else
                {
                    MessageBox.Show("Se borró el turno con éxito");
                    LlenarDGVTurnos();
                    LimpiarTurnos();
                    //btCargaTurno.Visible = false;
                    //btModificarTurno.Visible = false;
                    //btEliminarTurno.Visible = false;
                }
            }
        }
        #endregion

        # region DataSets
        public void dsATxtClientes(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
        }
        public void dsATxtTurnos(DataSet ds)
        {
            bool pagado;
            if (ds.Tables[0].Rows[0]["pagado"].ToString()=="si")
            {
                pagado = true;
            }
            else
            {
                pagado = false;
            }

            comboBoxClienteYTurno.SelectedItem= ds.Tables[0].Rows[0]["cliente"].ToString();
            textBoxDNI.Text= ds.Tables[0].Rows[0]["dni"].ToString();
            dateTimePicker.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"].ToString());
            texboxhora.Text= ds.Tables[0].Rows[0]["dni"].ToString();
            //texboxhora.Text= ds.Tables[0].Rows[0]["dni"].ToString();
            checkBoxPay.Checked = pagado;
            comboBarbero.SelectedItem= ds.Tables[0].Rows[0]["barbero"].ToString();

        }

        #endregion

        #region KeyPress Evento
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (!(char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void texboxhora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        #endregion

        #region Buscar
        private void btBuscar1_Click(object sender, EventArgs e)
        {
            LlenarDGVClientBusqueda();
        }
        private void btBuscar2_Click(object sender, EventArgs e)
        {
            LlenarDGVTurnosBusqueda();
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            LlenarDGVClient();
            LlenarDGVTurnos();
            textBoxBuscarCliente.Text = "";
            textBoxBuscarTurnos.Text ="";
            LimpiarCliente();
            LimpiarTurnos();

            //comboBoxClienteYTurno.DataSource = negoClientex.ListadoCliente("Todos");
            //comboBoxClienteYTurno.DisplayMember = "NOMBRE";
            //comboBoxClienteYTurno.ValueMember = "id";

            //btEliminar.Visible = false;
            //btCargar.Visible = false;
            //btModificar.Visible = false;
            //btEliminarTurno.Visible = false;
            //btCargaTurno.Visible = false;
            //btModificarTurno.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClienteYTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texboxhora_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
