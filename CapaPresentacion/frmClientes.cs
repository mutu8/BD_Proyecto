using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            listarCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.nombre = txtNombre.Text.Trim();
                c.dni = txtDNI.Text.Trim();
                c.edad = int.Parse(txtEdad.Text.Trim());
                c.telefono = int.Parse(txtTelefono.Text.Trim());
                c.email = txtEmail.Text.Trim();
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarCliente();
        }
        private void LimpiarVariables()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
        }
        private void listarCliente() 
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();
        }
    }
}

