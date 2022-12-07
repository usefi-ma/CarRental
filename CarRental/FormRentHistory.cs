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
    public partial class FormRentHistory : Form
    {
        public FormRentHistory()
        {
            InitializeComponent();
        }

        private void FormRentHistory_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerStartDate.Text = string.Empty;
                dateTimePickerEndDate.Text = string.Empty;

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
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void ClearForm()
        {
            dateTimePickerStartDate.Text = string.Empty;
            dateTimePickerEndDate.Text = string.Empty;
            comboBoxUser.SelectedIndex = -1;
            comboBoxVehicle.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
        }

        private void SearchData()
        {
            if (dateTimePickerStartDate.Text.Trim() != string.Empty || dateTimePickerEndDate.Text.Trim() != string.Empty ||
                comboBoxUser.SelectedIndex > -1 || comboBoxVehicle.SelectedIndex > -1 || comboBoxEmployee.SelectedIndex > -1)
            {
                throw new NotImplementedException();
            }
            else
            {
                MessageBox.Show("You have to enter one of the items in the form.", "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
