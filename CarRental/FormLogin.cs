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

namespace CarRental
{
    public partial class FormLogin : Form
    {
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("data source = (local);initial catalog=MyCarRental;integrated security = true");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmSignup = new FormSignup();
                frmSignup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    LoginUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void LoginUser()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from [user] Where Username=@a and Password=@b", conn);

            cmd.Parameters.AddWithValue("@a", txtUsername.Text);
            cmd.Parameters.AddWithValue("@b", txtPassword.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (txtUsername.Text == string.Empty && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter Username and Password","Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader.Read())
            {
                Form frmDashboard = new FormDashboard();
                this.Hide();
                frmDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            /*if (txtUsername.Text.Trim() != string.Empty && txtPassword.Text.Trim() != string.Empty)
            {
                if (txtUsername.Text.Trim() == "Admin" && txtPassword.Text.Trim() == "1234")
                {
                    //throw new NotImplementedException();
                    Form frmDashboard = new FormDashboard();
                    this.Hide();
                    frmDashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username and Password are not correct", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    }
}
