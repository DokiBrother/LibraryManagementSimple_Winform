using DGVPrinterHelper;
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
    public partial class CustomerDetailForm : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        DataSet ds = new DataSet();
        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printCustomerDetail;
            printDialog.UseEXDialog = true;

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printCustomerDetail.DocumentName = "Customer Report";
                printCustomerDetail.Print();
            }



        }

        private void printCustomerDetail_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printdocument = new Bitmap(this.dgvCustomerDetail.Width, this.dgvCustomerDetail.Height);
            dgvCustomerDetail.DrawToBitmap(printdocument, new Rectangle(0, 0, printdocument.Width, printdocument.Height));
            e.Graphics.DrawImage(printdocument, 0, 0);
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            query = "SELECT customerID AS 'ID',customerName AS 'Customer Name', customerNationalID AS 'National ID',customerGender AS 'Gender',customerPhone AS 'Phone',customerAddress AS 'Address',customerCheckInDay AS 'Check in',customerCheckOutDay AS 'Check out', labName AS 'LAB NAME',labPrice AS 'Price ($)' FROM CustomerTable INNER JOIN LabTable ON LabTable.labID = CustomerTable.labID;";
            ds = sqlGetSet.getData(query);
            dgvCustomerDetail.DataSource = ds.Tables[0];
            dgvCustomerDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerDetail.Columns[8].Width = 150;
            dgvCustomerDetail.Columns[0].Width = 50;

            foreach (DataGridViewColumn header in dgvCustomerDetail.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void BtnPrintReport_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.ColumnWidth = 0;
            //printer.HeaderCellFormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            printer.Footer = "Topic 9 Lab Reservation";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvCustomerDetail);
        }

        private void BtnReturnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            string checkGenderMale = "";
            string checkGenderFemale = "";
            string checkGenderOther = "";
            string customerCheckedOutOnly = "OR customerCheckOutDay IS NULL";
            decimal labPriceFrom = 0;
            decimal labPriceTo = 999999999;

            if (checkBoxMale.Checked)
            {
                checkGenderMale = "Male";
            }
            if (checkBoxFemale.Checked)
            {
                checkGenderFemale = "Female";
            }
            if (checkBoxOtherGender.Checked)
            {
                checkGenderOther = "Other";
            }
            if (!checkBoxMale.Checked && !checkBoxFemale.Checked && !checkBoxOtherGender.Checked)
            {
                checkGenderMale = "Male";
                checkGenderFemale = "Female";
                checkGenderOther = "Other";
            }
            if (cbCheckedOutOnly.Checked)
            {
                customerCheckedOutOnly = "AND customerCheckOutDay IS NOT NULL";
            }
            if (txtPriceFrom.Text != "")
            {
                labPriceFrom = decimal.Parse(txtPriceFrom.Text);
            }
            if (txtPriceTo.Text != "")
            {
                labPriceTo = decimal.Parse(txtPriceTo.Text);
            }

            if (txtSearchName.Text != "")
            {
                string customerName = txtSearchName.Text;
                string dateFrom = dtpDateFrom.Value.ToString("dd/MM/yyyy");
                string dateTo = dtpDateTo.Value.ToString("dd/MM/yyyy");
                try
                {
                    query = "SELECT customerID AS 'ID',customerName AS 'Customer Name', customerNationalID AS 'National ID',customerGender AS 'Gender',customerPhone AS 'Phone',customerAddress AS 'Address',customerCheckInDay AS 'Check in',customerCheckOutDay AS 'Check out', labName AS 'LAB NAME',labPrice AS 'Price ($)' FROM CustomerTable INNER JOIN LabTable ON LabTable.labID = CustomerTable.labID WHERE customerName LIKE '%" + customerName + "%' AND (customerGender = '" + checkGenderMale + "' OR customerGender = '" + checkGenderFemale + "' OR customerGender = '" + checkGenderOther + "') AND CONVERT(DATETIME,customerCheckInDay, 103) >= CONVERT(DATETIME,'" + dateFrom + "', 103) AND (CONVERT(DATETIME,customerCheckOutDay, 103) <= CONVERT(DATETIME,'" + dateTo + "', 103) " + customerCheckedOutOnly + ") AND labPrice > " + labPriceFrom + " AND labPrice < " + labPriceTo + ";";
                    ds = sqlGetSet.getData(query);
                    dgvCustomerDetail.DataSource = ds.Tables[0];
                    dgvCustomerDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("Cannot find any customer's name contains '" + customerName + "' with above options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (txtSearchName.Text == "")
            {
                string dateFrom = dtpDateFrom.Value.ToString("dd/MM/yyyy");
                string dateTo = dtpDateTo.Value.ToString("dd/MM/yyyy");
                try
                {
                    query = "SELECT customerID AS 'ID',customerName AS 'Customer Name', customerNationalID AS 'National ID',customerGender AS 'Gender',customerPhone AS 'Phone',customerAddress AS 'Address',customerCheckInDay AS 'Check in',customerCheckOutDay AS 'Check out', labName AS 'LAB NAME',labPrice AS 'Price ($)' FROM CustomerTable INNER JOIN LabTable ON LabTable.labID = CustomerTable.labID WHERE (customerGender = '" + checkGenderMale + "' OR customerGender = '" + checkGenderFemale + "' OR customerGender = '" + checkGenderOther + "') AND CONVERT(DATETIME,customerCheckInDay, 103) >= CONVERT(DATETIME,'" + dateFrom + "', 103) AND (CONVERT(DATETIME,customerCheckOutDay, 103) <= CONVERT(DATETIME,'" + dateTo + "', 103) " + customerCheckedOutOnly + ") AND labPrice > " + labPriceFrom + " AND labPrice < " + labPriceTo + ";";
                    DataSet ds = sqlGetSet.getData(query);
                    dgvCustomerDetail.DataSource = ds.Tables[0];
                    dgvCustomerDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("Cannot find any customer with above options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "Search by Name")
            {
                txtSearchName.Clear();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CustomerDetailForm_Load(this, null);
            dtpDateFrom.Value = new DateTime(2023, 01, 01);
            dtpDateTo.Value = DateTime.Today;
        }

        public System.Windows.Forms.DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }
    }
}
