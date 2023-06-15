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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnPasajes_Click(object sender, EventArgs e)
        {
            this.Hide();
            dgbItinerarios frm = new dgbItinerarios();
            frm.Show();
        }
    }
}
