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
    public partial class CheckOutForm : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        String query2;
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void BtnReturnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void BtnCheckOutNow_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "" && txtNationalID.Text != "" && timePickerCheckOut.Text != "")
            {
                int customerID = int.Parse(txtCustomerID.Text);
                string nationalID = txtNationalID.Text;
                string checkOut = timePickerCheckOut.Value.ToString("dd/MM/yyyy");

                query = "SELECT labID FROM CustomerTable WHERE customerID = " + customerID + ";";
                DataSet ds = sqlGetSet.getData(query);
                int labID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                try
                {
                    query2 = "SELECT customerCheckOutState FROM CustomerTable WHERE customerID = " + customerID + ";";
                    DataSet ds2 = sqlGetSet.getData(query2);
                    string checkOutState = ds2.Tables[0].Rows[0][0].ToString();
                    if (checkOutState == "NO")
                    {
                        query = "UPDATE CustomerTable SET customerCheckOutDay = '" + checkOut + "', customerCheckOutState = 'YES' WHERE (customerID = " + customerID + " AND customerNationalID = '" + nationalID + "' AND customerCheckOutState = 'NO'); UPDATE LabTable SET isReserved = 'Available' WHERE labID = " + labID + ";";

                        sqlGetSet.setData(query, "Check out!");
                        if (customerFeedBackBox.Checked)
                        {
                            CustomerFeedback feedback = new CustomerFeedback();
                            feedback.Show();
                        }
                        ClearInput();

                    }
                    else
                    {
                        MessageBox.Show("This customer checked out in the past!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please fill the required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void ClearInput()
        {
            txtCustomerID.Clear();
            txtNationalID.Clear();
            txtCustomerName.Clear();
            txtLabName.Clear();

        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            if (txtSearchName.Text != "")
            {
                string customerName = txtSearchName.Text;
                try
                {
                    query = "SELECT customerID AS 'ID',customerName AS 'Customer Name',customerNationalID AS 'National ID',customerPhone AS 'Phone Number', customerAddress AS 'Address',customerCheckInDay AS 'Check in Date',customerCheckOutDay AS 'Check out Date' FROM CustomerTable WHERE customerName LIKE '%" + customerName + "%'";
                    DataSet ds = sqlGetSet.getData(query);
                    dgvCheckOut.DataSource = ds.Tables[0];
                    dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("Cannot find any customer's name contains '" + customerName + "'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                CheckOutForm_Load(this, null);
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "")
            {
                int customerID = int.Parse(txtCustomerID.Text);
                query = "SELECT customerName,labID,customerNationalID FROM CustomerTable WHERE customerID = " + customerID + ";";
                DataSet ds = sqlGetSet.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int labID = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                    txtCustomerName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtNationalID.Text = ds.Tables[0].Rows[0][2].ToString();
                    query2 = "SELECT labName FROM LabTable WHERE labID = " + labID + ";";
                    DataSet ds2 = sqlGetSet.getData(query2);
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        txtLabName.Text = ds2.Tables[0].Rows[0][0].ToString();
                    }
                    else { txtLabName.Clear(); txtCustomerName.Clear(); txtNationalID.Clear(); }
                }
                else { txtLabName.Clear(); txtCustomerName.Clear(); txtNationalID.Clear(); }


            }
            else { txtLabName.Clear(); txtCustomerName.Clear(); txtNationalID.Clear(); }

        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            query = "SELECT customerID AS 'ID',customerName AS 'Customer Name',customerNationalID AS 'National ID',customerPhone AS 'Phone Number', customerAddress AS 'Address',customerCheckInDay AS 'Check in Date',customerCheckOutDay AS 'Check out Date' FROM CustomerTable";
            DataSet ds = sqlGetSet.getData(query);
            dgvCheckOut.DataSource = ds.Tables[0];
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearchName_Click(sender, e);
            }
        }

        public System.Windows.Forms.DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }
    }
}
