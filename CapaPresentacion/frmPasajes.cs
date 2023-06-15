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
    public partial class dgbItinerarios : Form
    {
        public dgbItinerarios()
        {
     
            InitializeComponent();
            LlenarDatos();
        }
        private void LlenarDatos()
        {


            //Cliente
            cboClientes.DataSource = logCliente.Instancia.ListarCliente();
            cboClientes.DisplayMember = "nombre";
            cboClientes.ValueMember = "idCliente";

            //Empresa
            cboEmpresa.DataSource = logCliente.Instancia.listaEmpresa();
            cboEmpresa.DisplayMember = "nombre";
            cboEmpresa.ValueMember = "idEmpresa";

            //Origen
            cboOrigen.DataSource = logCliente.Instancia.listaOrigen();
            cboOrigen.DisplayMember = "ciudadOrigen";
            cboOrigen.ValueMember = "idOrigen";

            //Destino
            cboDestino.DataSource = logCliente.Instancia.listaDestino();
            cboDestino.DisplayMember = "ciudadDestino";
            cboDestino.ValueMember = "idDestino";

            //Combo Tipo de pasajes
            cboTipoPasaje.SelectedIndex =-1;
            cboTipoPasaje.Items.Add("VIP");
            cboTipoPasaje.Items.Add("Regular");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idOrigen = Convert.ToInt32(cboOrigen.SelectedValue);
            int idDestino = Convert.ToInt32(cboDestino.SelectedValue);

            dgvItinerario.DataSource = logCliente.Instancia.listaItinerarioFiltrado(idOrigen,idDestino);

            cboItinerario.DataSource = logCliente.Instancia.listaItinerarioFiltrado(idOrigen, idDestino);
            cboItinerario.DisplayMember = "idItinerario";
            cboItinerario.ValueMember = "idItinerario";
        }

        private void btnFiltrarViajes_Click(object sender, EventArgs e)
        {
            int idItinerario = Convert.ToInt32(cboItinerario.SelectedValue);

            dgvViajes.DataSource = logCliente.Instancia.listaViajeFiltrado(idItinerario);
            numericUpDown1.Maximum = logCliente.Instancia.listaViajeFiltrado(idItinerario)[0].capacidad;
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cboEmpresa.SelectedIndex;
            n++;

            lbId.Text = n.ToString();
        }
    }
}
