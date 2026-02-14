using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Applications.ManageApplications
{
    public partial class frmListApplications : Form
    {
        private DataTable _dtApplications;

        public frmListApplications()
        {
            InitializeComponent();
        }

        private void pnlFilters_Paint(object sender, PaintEventArgs e)
        {
            _dtApplications = clsApplicationType.GetAllApplicationTypes();

            dgvApplications.DataSource = _dtApplications;

            lblRecordCount.Text= dgvApplications.Rows.Count.ToString();
        }
    }
}
