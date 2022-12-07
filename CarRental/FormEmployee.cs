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

namespace CarRental
{
    public partial class FormEmployee : Form
    {
        DBManager dbManager = new DBManager();

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                SearchData();
                LoadUsers();
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
                SaveDate();
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
                EditDate();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchData(comboBoxRole.Text,Int16.Parse(comboBoxUser.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridViewMain.SelectedRows[0];
                    txtID.Text = row.Cells["EmployeeId"].Value.ToString();
                    comboBoxRole.Text = row.Cells["Role"].Value.ToString();
                    comboBoxUser.Text = row.Cells["UserId"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private void ClearForm()
        {
            txtID.Text = string.Empty;
            comboBoxUser.SelectedIndex = -1;
            comboBoxRole.SelectedIndex = -1;
            SearchData();
        }

        private void SaveDate()
        {
            if (comboBoxRole.SelectedIndex > -1 && comboBoxUser.SelectedIndex > -1)
            {
                string queryString = "INSERT INTO Employee VALUES ( '" + comboBoxRole.Text + "'," + comboBoxUser.Text + ");";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item saved successfully", "Car Rental - save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Car Rental - save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditDate()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "UPDATE Employee SET Role='" + comboBoxRole.Text + "',UserId="+ comboBoxUser.Text + " WHERE EmployeeId=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item edit successfully", "Car Rental - edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Car Rental - edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteData()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "DELETE FROM Employee WHERE EmployeeId=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item delete successfully", "Car Rental - delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Car Rental - delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchData()
        {
            string queryString = "Select * FROM Employee";
            DataTable dtData = dbManager.SelectData(queryString);
            dataGridViewMain.DataSource = dtData;
        }
        private void SearchData(string RoleName, int UserID = 0)
        {
            if (RoleName != String.Empty || UserID > 0)
            {
                string queryString = "Select * FROM Employee where EmployeeId > 0 ";

                if (RoleName != String.Empty)
                    queryString = "And Role Like'%" + RoleName + "%'";

                if (UserID > 0)
                    queryString = "And UserID =" + UserID;

                DataTable dtData = dbManager.SelectData(queryString);
                dataGridViewMain.DataSource = dtData;
            }
            else
            {
                MessageBox.Show("Enter something for search", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadUsers()
        {
            string queryString = "Select UserId FROM [User]";
            DataTable dtUsers = dbManager.SelectData(queryString);
            if(dtUsers != null)
            {
                for(int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    comboBoxUser.Items.Add(dtUsers.Rows[i]["userId"].ToString());
                }
            }
        }

    }
}
