using Bank_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People
{
    public partial class frmListPeople : Form
    {

        private DataTable _dtPeople;
        public frmListPeople()
        {
            InitializeComponent();
        }

      

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _dtPeople = clsPerson.GetAllPeople();

            dgvPeople.DataSource = _dtPeople;   

            lblRecordCount.Text= dgvPeople.Rows.Count.ToString();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }
    }
}
