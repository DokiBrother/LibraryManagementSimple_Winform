using System;
using System.Collections;
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
    public partial class CustomerRegistration : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = sqlGetSet.getDataComboBox(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void BtnReturnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BtnAllocateLab_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtNationalID.Text != "" && cbGender.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && cbLabName.Text != "" && cblabSpecialization.Text != "" && timePickerCheckIn.Text != "")
            {
                string customerName = txtCustomerName.Text;
                string nationalID = txtNationalID.Text;
                string customerGender = cbGender.Text;
                string customerPhone = txtPhone.Text;
                string customerAddress = txtAddress.Text;
                string checkIn = timePickerCheckIn.Value.ToString("dd/MM/yyyy");
                string labName = cbLabName.Text;
                string labID = txtLabID.Text;

                query = "INSERT INTO CustomerTable(customerName,customerNationalID,customerGender,customerPhone,customerAddress,customerCheckInDay,labID) VALUES ('" + customerName + "','" + nationalID + "','" + customerGender + "','" + customerPhone + "','" + customerAddress + "','" + checkIn + "','" + labID + "'); UPDATE LabTable SET isReserved = 'Reserving' WHERE labID = '" + labID + "'";
                sqlGetSet.setData(query, "Lab Added!");
                ClearInput();
            }
            else
            {
                MessageBox.Show("Please fill the required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearInput()
        {
            txtCustomerName.Clear();
            txtNationalID.Clear();
            cbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            cbLabName.SelectedIndex = -1;
            cblabSpecialization.SelectedIndex = -1;
            txtLabPrice.Clear();
            txtLabID.Clear();
        }

        private void cblabSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLabName.SelectedIndex = -1;
            cbLabName.Items.Clear();
            txtLabPrice.Clear();
            txtLabID.Clear();
            query = "SELECT labName FROM LabTable WHERE (labSpecialization = '" + cblabSpecialization.Text + "' AND isReserved='Available');";
            setComboBox(query, cbLabName);
        }

        private void cbLabName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLabPrice.Clear();
            txtLabID.Clear();
            query = "SELECT labPrice,labID FROM LabTable WHERE labName = '" + cbLabName.Text + "'";
            DataSet ds = sqlGetSet.getData(query);
            if (cbLabName.SelectedIndex != -1)
            {
                txtLabPrice.Text = ds.Tables[0].Rows[0][0].ToString();
                txtLabID.Text = ds.Tables[0].Rows[0][1].ToString();
            }

        }
    }
}
