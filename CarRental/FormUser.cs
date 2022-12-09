using CarRental.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRental
{
    public partial class FormUser : Form
    {
        DBManager dbManager = new DBManager();

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                SearchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchData(txtFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dataGridViewMain_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridViewMain.SelectedRows[0];
                    txtID.Text = row.Cells["UserId"].Value.ToString();
                    txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                    txtLastName.Text = row.Cells["LastName"].Value.ToString();
                    txtUserName.Text = row.Cells["Username"].Value.ToString();
                    txtBirthDate.Text = row.Cells["BirthDate"].Value.ToString();
                    txtPassword.Text = row.Cells["Password"].Value.ToString();
                    txtAddress.Text = row.Cells["Address"].Value.ToString();
                    txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void ClearForm()
        {
            txtID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBirthDate.Text = string.Empty;

            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            SearchData();
        }
        private void SaveDate()
        {
            if (txtFirstName.Text.Trim() != string.Empty && txtLastName.Text.Trim() != string.Empty && txtEmail.Text.Trim() != string.Empty &&
                txtPhone.Text.Trim() != string.Empty && txtAddress.Text.Trim() != string.Empty && txtBirthDate.Text.Trim() != string.Empty &&
                txtPassword.Text.Trim() != string.Empty && txtUserName.Text.Trim() != string.Empty)
            {
                string queryString = "INSERT INTO [User] VALUES ( '" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtBirthDate.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "',0)";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item saved successfully", "User - save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "User - save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditDate()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "UPDATE [User] SET FirstName='" + txtFirstName.Text + "'" +
                    ",LastName='" + txtLastName.Text + "'" +
                    ",BirthDate='" + txtBirthDate.Text + "'" +
                    ",Username='" + txtUserName.Text + "'" +
                    ",Password='" + txtPassword.Text + "'" +
                    ",Address='" + txtAddress.Text + "'" +
                    ",PhoneNumber='" + txtPhone.Text + "'" +
                    ",Email='" + txtEmail.Text + "'" +
                    " WHERE UserId=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item edit successfully", "User - edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "User - edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteData()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "DELETE FROM [User] WHERE UserId=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item delete successfully", "User - delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "User - delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchData()
        {
            string queryString = "Select * FROM [User]";
            DataTable dtData = dbManager.SelectData(queryString);
            dataGridViewMain.DataSource = dtData;
        }
        private void SearchData(string Username)
        {
            if (Username != String.Empty)
            {
                string queryString = "Select * FROM [User] where Username Like'%" + Username + "%'";
                DataTable dtData = dbManager.SelectData(queryString);
                dataGridViewMain.DataSource = dtData;
            }
            else
            {
                MessageBox.Show("Enter something for search", "User - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
