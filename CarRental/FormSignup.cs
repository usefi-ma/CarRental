using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            try
            {
                txtBirthDate.Text = string.Empty;

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
                SignupUser();
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
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBirthDate.Text = string.Empty;

            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPassword2.Text = string.Empty;
        }

        private void SignupUser()
        {
            if (txtFirstName.Text.Trim() != string.Empty && txtLastName.Text.Trim() != string.Empty && txtEmail.Text.Trim() != string.Empty &&
                txtPhone.Text.Trim() != string.Empty && txtAddress.Text.Trim() != string.Empty && txtBirthDate.Text.Trim() != string.Empty &&
                txtPassword.Text.Trim() != string.Empty && txtPassword2.Text.Trim() != string.Empty)
            {
                if (txtPassword.Text.Trim() == txtPassword2.Text.Trim())
                {
                    throw new NotImplementedException();
                }
                else
                {
                    MessageBox.Show("Your passwords are not match !!!", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
