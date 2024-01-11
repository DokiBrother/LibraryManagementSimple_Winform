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
    public partial class CustomerFeedback : Form
    {
        ConnectSQLGetSetDataFunction sqlGetSet = new ConnectSQLGetSetDataFunction();
        String query;
        public CustomerFeedback()
        {
            InitializeComponent();
        }

        private void txtTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTitle.Text == "Customer Problem Title")
            {
                txtTitle.Clear();
            }
        }

        private void txtContent_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContent.Text == "Detail the problem")
            {
                txtContent.Clear();
            }

        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                txtContent.Text = "Detail the problem";
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Customer Problem Title";
            }
        }

        private void BtnSaveFeedback_Click(object sender, EventArgs e)
        {
            string fbType = cbProblemType.Text;
            string fbTitle = txtTitle.Text;
            string fbContent = txtContent.Text;
            try
            {
                if (txtContent.Text != "" && txtContent.Text != "Detail the problem" && txtTitle.Text != "" && txtTitle.Text != "Customer Problem Title")
                {
                    query = "INSERT FeedbackTable(fbType,fbTitle,fbContent) VALUES ('"+fbType+"','"+fbTitle+"','"+fbContent+"');";
                    sqlGetSet.setData(query, "Saved customer feedback");
                    DialogResult anotherFeedback = MessageBox.Show("Send an other feedback?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anotherFeedback == DialogResult.Yes)
                    {
                        CustomerFeedback customerFeedback2 = new CustomerFeedback();
                        this.Hide();
                        customerFeedback2.Show();
                    } else
                    {
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Please write down the details of problems!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }
}
