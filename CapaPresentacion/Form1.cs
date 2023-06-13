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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listarCliente();
            listarOrigen();
            listaDestino();
            listaItinerario();
            listaEmpresa();
            listaViaje();
            listaPasaje();
        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        public void listarOrigen()
        {
            dgvOrigen.DataSource = logCliente.Instancia.listaOrigen();
        }
        public void listaDestino()
        {
            dgvDestino.DataSource = logCliente.Instancia.listaDestino();
        }
        public void listaItinerario()
        {
            dgvItinerario.DataSource = logCliente.Instancia.listaItinerario();
        }
        public void listaEmpresa()
        {
            dgvEmpresa.DataSource = logCliente.Instancia.listaEmpresa();
        }
        public void listaViaje()
        {
            dgvViaje.DataSource = logCliente.Instancia.listaViaje();
        }
        public void listaPasaje()
        {
            dgvPasaje.DataSource = logCliente.Instancia.listaPasaje();
        }


    }
}
