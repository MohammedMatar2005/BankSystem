using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmListClients : Form
    {
        private DataTable _dtClients;
        public frmListClients()
        {
            InitializeComponent();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            
        }

        private void frmListClients_Load(object sender, EventArgs e)
        {
            _dtClients = clsClient.GetAllClients();

            dgvClients.DataSource = _dtClients;

            if (dgvClients.Rows.Count > 0)
            {


                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 100;

                dgvClients.Columns[1].HeaderText = "Person ID";
                dgvClients.Columns[1].Width = 100;

                dgvClients.Columns[3].HeaderText = "Full Name";
                dgvClients.Columns[3].Width = 400;

                dgvClients.Columns[2].HeaderText = "National Number";
                dgvClients.Columns[2].Width = 350;


            }

           
        }
    }
}
