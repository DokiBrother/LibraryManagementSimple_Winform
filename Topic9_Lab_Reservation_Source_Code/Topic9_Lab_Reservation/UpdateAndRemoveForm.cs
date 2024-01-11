using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic9_Lab_Reservation
{
    public partial class UpdateAndRemoveForm : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        public UpdateAndRemoveForm()
        {
            InitializeComponent();
        }
        public void ClearInput()
        {
            txtLabName.Clear();
            txtLabPrice.Clear();
            txtLabID.Clear();
            cblabSpecialization.SelectedIndex = -1;
        }
        private void BtnReturnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void BtnUpdateLab_Click(object sender, EventArgs e)
        {
            if (txtLabName.Text != "" && txtLabPrice.Text != "" && cblabSpecialization.Text != "")
            {
                int labID = Convert.ToInt32(txtLabID.Text);
                string labName = txtLabName.Text;
                string labSpecialization = cblabSpecialization.Text;
                decimal labPrice = decimal.Parse(txtLabPrice.Text);

                query = "UPDATE LabTable SET labName = '" + labName + "', labSpecialization = '" + labSpecialization + "', labPrice = " + labPrice + " WHERE labID = " + labID + ";";
                sqlGetSet.setData(query, "Updated Lab!");
                UpdateAndRemoveForm_Load(this, null);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Please fill the required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateAndRemoveForm_Load(object sender, EventArgs e)
        {
            query = "Select labID as ID, labName as Name, labSpecialization as Specialization, labPrice as Price, isReserved as State from LabTable";
            DataSet ds = sqlGetSet.getData(query);
            dgvUpdateRemoveLab.DataSource = ds.Tables[0];
            dgvUpdateRemoveLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpdateRemoveLab.Columns[0].Width = 50;
            dgvUpdateRemoveLab.Columns[1].Width = 150;
            dgvUpdateRemoveLab.Columns[2].Width = 150;
        }

        private void BtnRemoveLab_Click(object sender, EventArgs e)
        {
            if (txtLabID.Text != "")
            {
                DialogResult confirm = MessageBox.Show("Are you sure to delete lab: " + txtLabID.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int labID = Convert.ToInt32(txtLabID.Text);

                        //Conflicted with CustomerTable (LabID) because of Foreign key
                        query = "DELETE FROM LabTable WHERE labID = " + labID + ";";
                        sqlGetSet.setData(query, "Remove Lab!");
                        UpdateAndRemoveForm_Load(this, null);
                        ClearInput();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This lab is at reservation or does not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            } else
            {
                MessageBox.Show("Please enter Lab ID you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public System.Windows.Forms.DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }

    }
}
