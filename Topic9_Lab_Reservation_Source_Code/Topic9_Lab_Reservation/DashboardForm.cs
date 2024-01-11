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
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            AddLabForm addRoomForm = new AddLabForm();
            this.Hide();
            addRoomForm.Show();

        }

        private void BtnCustomerRegistration_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            this.Hide();
            customerRegistration.Show();
        }

        private void BtnUpdateLab_Click(object sender, EventArgs e)
        {
            UpdateAndRemoveForm updateRemove = new UpdateAndRemoveForm();
            this.Hide();
            updateRemove.Show();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            this.Hide();
            checkOutForm.Show();
        }

        private void BtnCustomerDetail_Click(object sender, EventArgs e)
        {
            CustomerDetailForm customerDetailForm = new CustomerDetailForm();
            this.Hide();
            customerDetailForm.Show();
        }
    }
}
