using CarRental.Class;
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
    public partial class FormVehicleType : Form
    {

        DBManager dbManager = new DBManager();
        private List<VehicleType> vehicleTypes = new List<VehicleType>();

        public FormVehicleType()
        {
            InitializeComponent();
        }

        private void FormVehicleType_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchData(txtTypeName.Text);
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
        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridViewMain.SelectedRows[0];
                    txtID.Text = row.Cells["TypeId"].Value.ToString();
                    txtTypeName.Text = row.Cells["TypeName"].Value.ToString();
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
            txtTypeName.Text = string.Empty;
            SearchData();
        }

        private void SaveDate()
        {
            if (txtTypeName.Text.Trim() != "")
            {
                string queryString = "INSERT INTO VehicleType VALUES ( '" + txtTypeName.Text + "');";
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
                string queryString = "UPDATE VehicleType SET TypeName='" + txtTypeName.Text + "' WHERE TypeId=" + txtID.Text + ";";
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
                string queryString = "DELETE FROM VehicleType WHERE TypeId=" + txtID.Text + ";";
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
            string queryString = "Select * FROM VehicleType";
            DataTable vehicle = dbManager.SelectData(queryString);
            dataGridViewMain.DataSource = vehicle;
        }
        private void SearchData(string typeName)
        {
            if (typeName != String.Empty)
            {
                string queryString = "Select * FROM VehicleType where TypeName Like'%" + typeName + "%'";
                DataTable vehicle = dbManager.SelectData(queryString);
                dataGridViewMain.DataSource = vehicle;
            }
            else
            {
                MessageBox.Show("Enter something for search", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
