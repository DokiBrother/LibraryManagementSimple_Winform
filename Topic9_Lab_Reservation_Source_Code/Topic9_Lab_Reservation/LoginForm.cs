using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Topic9_Lab_Reservation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password!");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-HBH50E9\\DCTDB;User ID=sa;Password=123456789;Initial Catalog=Lab_Reservation;Integrated Security=False;Encrypt=False;Trusted_Connection=True;";
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("Select * from UserLogin where userName = @userName and userPassword = @userPassword;", conn);
                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully!");
                        DashboardForm dashboardForm = new DashboardForm();
                        this.Hide();
                        dashboardForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
