using CarRental.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormVehicle : Form
    {
        DBManager dbManager = new DBManager();
        public FormVehicle()
        {
            InitializeComponent();
        }

        private void FormVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerRegisterDate.Text = string.Empty;
                SearchData();

                //populating User combo box
                string UserQueryString = "Select TypeId,TypeName FROM VehicleType";
                DataTable UdtData = dbManager.SelectData(UserQueryString);

                comboBoxVehicleType.DataSource = UdtData;
                comboBoxVehicleType.DisplayMember = "TypeName";
                comboBoxVehicleType.ValueMember = "TypeId";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Vehicle Type - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                SearchData(txtBrand.Text, txtYear.Text, txtColor.Text, txtPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {

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
            txtID.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtPrice.Text = string.Empty;

            comboBoxVehicleType.SelectedIndex = -1;
            comboBoxIsRented.SelectedIndex = -1;
            comboBoxIsDeleted.SelectedIndex = -1;

            dateTimePickerRegisterDate.Text = string.Empty;
            listViewImages.Clear();
            listViewComments.Clear();

            // Select all data and show in grid
            SearchData();
        }
        private void dataGridViewMain_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridViewMain.SelectedRows[0];
                    txtID.Text = row.Cells["VehicleID"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtYear.Text = row.Cells["Year"].Value.ToString();
                    txtColor.Text = row.Cells["Color"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    comboBoxIsRented.Text = row.Cells["IsRented"].Value.ToString();
                    dateTimePickerRegisterDate.Text = row.Cells["RegisteredDate"].Value.ToString();
                    comboBoxVehicleType.Text = row.Cells["Type"].Value.ToString();
                    comboBoxIsDeleted.Text = row.Cells["IsDeleted"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void SaveData()
        {
            if (txtBrand.Text.Trim() != string.Empty && txtYear.Text.Trim() != string.Empty && txtColor.Text.Trim() != string.Empty &&
                txtPrice.Text.Trim() != string.Empty && comboBoxVehicleType.SelectedIndex > -1 && comboBoxIsRented.SelectedIndex > -1 &&
                comboBoxIsDeleted.SelectedIndex > -1 && dateTimePickerRegisterDate.Text.Trim() != string.Empty)
            {
                string queryString = "INSERT INTO Vehicle VALUES ( '" + txtBrand.Text + "','" + Int32.Parse(txtYear.Text) + "','" + txtColor.Text + "','" + txtPrice.Text + "'," + comboBoxIsRented.SelectedIndex + ",'" + dateTimePickerRegisterDate.Value.ToShortDateString() + "'," + comboBoxVehicleType.SelectedIndex + 1 + "," + comboBoxIsDeleted.SelectedIndex + ")";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item saved successfully", "Vehicle - save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Vehicle - save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form.", "Vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditData()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "UPDATE Vehicle SET Brand='" + txtBrand.Text + "'" +
                    ",Year='" + txtYear.Text + "'" +
                    ",Color='" + txtColor.Text + "'" +
                    ",Price='" + txtPrice.Text + "'" +
                    ",IsRented='" + comboBoxIsRented.Text + "'" +
                    ",RegisteredDate='" + dateTimePickerRegisterDate.Value.ToShortDateString() + "'" +
                    ",Type='" + comboBoxVehicleType.SelectedIndex + "'" +
                    ",IsDeleted='" + comboBoxIsDeleted.SelectedIndex + "'" +
                    " WHERE VehicleID=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item edit successfully", "Vehicle - edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Vehicle - edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteData()
        {
            if (txtID.Text.Trim() != "")
            {
                string queryString = "DELETE FROM Vehicle WHERE VehicleID=" + txtID.Text + ";";
                bool status = dbManager.ManageData(queryString);
                if (status)
                {
                    MessageBox.Show("Item delete successfully", "Vehicle - delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("An error has occurred", "Vehicle - delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all items in the form", "Vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchData()
        {
            string queryString = "Select * FROM Vehicle";
            DataTable dtData = dbManager.SelectData(queryString);
            dataGridViewMain.DataSource = dtData;
        }
        private void SearchData(string brand, string year, string color, string price)
        {
            if (txtBrand.Text.Trim() != string.Empty || txtYear.Text.Trim() != string.Empty || txtColor.Text.Trim() != string.Empty ||
              txtPrice.Text.Trim() != string.Empty)
            {
                string queryString = "select * from Vehicle where Brand like N'%" + brand + "%' and Color like N'%" + color + "%' and Price like N'%" + price + "%'";
                DataTable dtData = dbManager.SelectData(queryString);
                dataGridViewMain.DataSource = dtData;
            } 
            else
            {
                MessageBox.Show("You have to enter one of the items in the form.", "Vehicle - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
