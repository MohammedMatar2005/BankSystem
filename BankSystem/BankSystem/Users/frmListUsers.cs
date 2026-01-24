using Bank_Business;
using BankSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmListUsers : Form
    {

        private DataTable _dtUsers;
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtUsers = clsUser.GetAllUsers_View();
            dgvUsers.DataSource = _dtUsers;

            if (dgvUsers.Rows.Count > 0)
            {


                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Full Name";
                dgvUsers.Columns[1].Width = 300;

                dgvUsers.Columns[2].HeaderText = "National Number";
                dgvUsers.Columns[2].Width = 200;

                dgvUsers.Columns[3].HeaderText = "Username";
                dgvUsers.Columns[3].Width = 200;

                dgvUsers.Columns[4].HeaderText = "Is active";
                dgvUsers.Columns[4].Width = 100;
            }

            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }
    }
}
