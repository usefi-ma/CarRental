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
    public partial class FormVehicle : Form
    {
        public FormVehicle()
        {
            InitializeComponent();
        }

        private void FormVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerRegisterDate.Text = string.Empty;

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            ClearForm();
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
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
        }
        private void SaveData()
        {
            if (txtBrand.Text.Trim() != string.Empty && txtYear.Text.Trim() != string.Empty && txtColor.Text.Trim() != string.Empty &&
                txtPrice.Text.Trim() != string.Empty && comboBoxVehicleType.SelectedIndex > -1 && comboBoxIsRented.SelectedIndex > -1 &&
                comboBoxIsDeleted.SelectedIndex > -1 && dateTimePickerRegisterDate.Text.Trim() != string.Empty)
            {
                throw new NotImplementedException();
            }
            else
            {
                MessageBox.Show("Enter all items in the form.", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
