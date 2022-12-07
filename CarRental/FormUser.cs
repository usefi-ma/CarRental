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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchData();
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
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void FormClear()
        {
            txtID.Text =string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBirthDate.Text = string.Empty;

            txtBirthDate.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void SaveData()
        {
            if (txtFirstName.Text.Trim() != string.Empty && txtLastName.Text.Trim() != string.Empty && txtEmail.Text.Trim() != string.Empty &&
                txtPhone.Text.Trim() != string.Empty && txtAddress.Text.Trim() != string.Empty && txtBirthDate.Text.Trim() != string.Empty &&
                txtPassword.Text.Trim() != string.Empty)
            {
                throw new NotImplementedException();
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditData()
        {
            throw new NotImplementedException();
        }

        private void DeleteData()
        {
            throw new NotImplementedException();
        }

        private void SearchData()
        {
            throw new NotImplementedException();
        }
    }
}
