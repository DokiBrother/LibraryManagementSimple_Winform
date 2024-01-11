using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic9_Lab_Reservation
{
    public partial class AddLabForm : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        public AddLabForm()
        {
            InitializeComponent();
        }

        private void BtnReturnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void AddLabForm_Load(object sender, EventArgs e)
        {
            query = "Select labID as ID, labName as Name, labSpecialization as Specialization, labPrice as Price, isReserved as State from LabTable";
            DataSet ds = sqlGetSet.getData(query);
            dgvAddLab.DataSource = ds.Tables[0];
            dgvAddLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAddLab.Columns[0].Width = 50;
            dgvAddLab.Columns[1].Width = 150;
            dgvAddLab.Columns[2].Width = 150;

        }

        private void BtnAddLab_Click(object sender, EventArgs e)
        {
            if (txtLabName.Text != "" && txtLabPrice.Text != "" && cblabSpecialization.Text != "")
            {
                string labName = txtLabName.Text;
                string labSpecialization = cblabSpecialization.Text;
                decimal labPrice = decimal.Parse(txtLabPrice.Text);

                query = "INSERT INTO LabTable(labName,labSpecialization,labPrice) VALUES ('" + labName + "','" + labSpecialization + "'," + labPrice + ")";
                sqlGetSet.setData(query, "Lab Added!");
                AddLabForm_Load(this, null);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Please fill the required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearInput()
        {
            txtLabName.Clear();
            txtLabPrice.Clear();
            cblabSpecialization.SelectedIndex = -1;
        }
        public System.Windows.Forms.DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }

    }
}
