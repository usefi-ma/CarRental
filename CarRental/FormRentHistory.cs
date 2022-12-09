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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental
{

    public partial class FormRentHistory : Form
    {
        DBManager dbManager = new DBManager();
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
                SearchData();



                //populating User combo box
                string UserQueryString = "Select UserId,FirstName,LastName FROM [User]";
                DataTable UdtData = dbManager.SelectData(UserQueryString);

                comboBoxUser.DataSource = UdtData;
                comboBoxUser.DisplayMember = "FirstName";
                comboBoxUser.ValueMember = "UserId";

                //populating Employee combo box
                string EmployeeQueryString = "SELECT * FROM Employee INNER JOIN [User] ON Employee.UserID=[User].UserId;";
                DataTable EdtData = dbManager.SelectData(EmployeeQueryString);

                comboBoxEmployee.DataSource = EdtData;
                comboBoxEmployee.DisplayMember = "FirstName";
                comboBoxEmployee.ValueMember = "EmployeeID";
                //populating Vehicle combo box
                string VehicleQueryString = "Select VehicleID,Brand FROM Vehicle";
                DataTable VdtData = dbManager.SelectData(VehicleQueryString);

                comboBoxVehicle.DataSource = VdtData;
                comboBoxVehicle.DisplayMember = "Brand";
                comboBoxVehicle.ValueMember = "VehicleID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Renting - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchData(comboBoxUser.SelectedIndex,comboBoxVehicle.SelectedIndex,
                    comboBoxEmployee.SelectedIndex,dateTimePickerStartDate.Text, 
                    dateTimePickerEndDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Renting - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(ex.Message.ToString(), "Renting - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void ClearForm()
        {
            dateTimePickerStartDate.Text = string.Empty;
            dateTimePickerEndDate.Text = string.Empty;
            comboBoxUser.SelectedIndex = -1;
            comboBoxVehicle.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            SearchData();
        }
        private void SearchData()
        {
            string queryString = "SELECT RentingID,Vehicle.Brand as Brand,[User].FirstName as [User],\r\n(SELECT [User].FirstName FROM Employee INNER JOIN [User] ON Employee.UserID=[User].UserId where Employee.EmployeeID=Renting.EmpID) as Employee,StartDate,EndDate,DailyCost,RequestDate \r\nFROM Renting INNER JOIN [User] ON Renting.UserID=[User].UserId\r\nINNER JOIN Vehicle ON Renting.VehicleID=Vehicle.VehicleID\r\nINNER JOIN Employee ON Renting.EmpID=Employee.EmployeeID;";
            DataTable dtData = dbManager.SelectData(queryString);
            dataGridViewMain.DataSource = dtData;
        }
        private void SearchData(int UserID, int EmpID, int VehicleID, string StartDate, string EndDate)
        {
            if (dateTimePickerStartDate.Text.Trim() != string.Empty || dateTimePickerEndDate.Text.Trim() != string.Empty ||
                comboBoxUser.SelectedIndex > -1 || comboBoxVehicle.SelectedIndex > -1 || comboBoxEmployee.SelectedIndex > -1)
            {
                //string queryString = "select * from Renting where UserID like %" + UserID + "% and EmpID like %" + EmpID + "% and VehicleID %" + VehicleID + "% and StartDate>=" + StartDate + " and EndDate<=" + EndDate + "";
                string queryString = "select * from Renting where StartDate>='" + StartDate + "' and EndDate<='" + EndDate + "'";
                DataTable dtData = dbManager.SelectData(queryString);
                dataGridViewMain.DataSource = dtData;
            }
            else
            {
                MessageBox.Show("You have to enter one of the items in the form.", "Renting - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
