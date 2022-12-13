using CarRental.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormDashboard : Form
    {
        DBManager dbManager = new DBManager();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlConnection conn = new SqlConnection("data source =(local);initial catalog=MyCarRental;integrated security = true");
        private List<Vehicle> cars = new List<Vehicle>();
        public int vehicleId = 0;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            dataGridViewAllRent.ColumnCount = 3;
            dataGridViewAllRent.Columns[0].Name = "Brand";
            dataGridViewAllRent.Columns[1].Name = "Customer";
            dataGridViewAllRent.Columns[2].Name = "Price";

            conn.Open();

            cmd = new SqlCommand("Select Count(VehicleID) From Vehicle", conn);
            lblAllVehicleNo.Text = Convert.ToString(cmd.ExecuteScalar());

            string loadQuery = "Select VehicleID, Brand, Year, Color, Price, Type FROM Vehicle";
            cmd = new SqlCommand(loadQuery, conn);

            var reader = cmd.ExecuteReader();

            DataTable vehicle = new DataTable();

            vehicle.Load(reader);
            dataGridViewAllVehicles.DataSource = vehicle;

            for (int row = 0; row < vehicle.Rows.Count; row++)
            {
                int vehicleId = (int)vehicle.Rows[row]["VehicleID"];
                string brand = vehicle.Rows[row]["Brand"].ToString();
                string price = vehicle.Rows[row]["Price"].ToString();

                Vehicle vehicleData = new Vehicle()
                {
                    vehicleID = vehicleId,
                    brand = brand,
                    price = price
                };
                cars.Add(vehicleData);
            }
            conn.Close();
            lblAllVehicleNo.Text = vehicle.Rows.Count.ToString();
            loadRent();
            allRent();
            loadUser();
            loadEmployee();


        }
        private void loadUser()
        {
            string queryString = "Select * FROM [User]";
            DataTable dtData = dbManager.SelectData(queryString);
            lblAllUserNo.Text = dtData.Rows.Count.ToString();
        }
        private void loadEmployee()
        {
            string queryString = "Select * FROM Employee";
            DataTable dtData = dbManager.SelectData(queryString);
            lblAllEmployeeNo.Text = dtData.Rows.Count.ToString();
        }
        private void loadRent()
        {
            string queryString = "Select * FROM Vehicle where IsRented=1";
            DataTable dtData = dbManager.SelectData(queryString);
            lblRentVevicleNo.Text = dtData.Rows.Count.ToString();
        }
        private void allRent()
        {
            string queryString = "Select * FROM Renting";
            DataTable dtData = dbManager.SelectData(queryString);
            lblAllRentNo.Text = dtData.Rows.Count.ToString();
        }
        private void mnuAboutForm_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmAbout = new AboutBoxMain();
                frmAbout.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmHelp = new Form_Help();
                frmHelp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuRentHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmRentHistory = new FormRentHistory();
                frmRentHistory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuManageCar_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmVehicle = new FormVehicle();
                frmVehicle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuManageUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmUser = new FormUser();
                frmUser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmRentHistory = new FormRentHistory();
                frmRentHistory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        private void mnuManageEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmEmployee = new FormEmployee();
                frmEmployee.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void mnuManageVehicleType_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmVehicleType = new FormVehicleType();
                frmVehicleType.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void mnuAboutTeam_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmTeamMemeber = new FormTeamMember();
                frmTeamMemeber.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRefreshVevicleInfo_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select Count(VehicleID) From Vehicle", conn);
            lblAllVehicleNo.Text = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
        }

        private void btnRefreshRentInfo_Click(object sender, EventArgs e)
        {
            try
            {
                LoadRentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRefreshUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                LoadUserInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRefreshEmployeeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEmployeeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearchAllVehicles_Click(object sender, EventArgs e)
        {
            conn.Open();
            adpt = new SqlDataAdapter("Select * from Vehicle Where Brand like '" + txtSearchAllVehicles.Text + "%'", conn);
            DataTable vehicle = new DataTable();
            adpt.Fill(vehicle);
            dataGridViewAllVehicles.DataSource = vehicle;
            conn.Close();
        }

        private void btnAddToFavoriteVehicle_Click(object sender, EventArgs e)
        {

            try
            {
                AddToFavoriteVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btnVehicleComment_Click(object sender, EventArgs e)
        {
            try
            {
                AddVehicleComment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSerachFavoriteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFavoriteVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRemoveFavoriteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveFavoriteVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewFavoriteVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRentVehicle_Click(object sender, EventArgs e)
        {
            DateTimePicker d1 = dateTimePickerStartDate;
            DateTimePicker d2 = dateTimePickerEndDate;

            //Calculating time difference
            TimeSpan diff = d2.Value - d1.Value;
            double time = double.Parse(diff.ToString("dd"));
            string price = txtDailyCost.Text;
            //Calculating cost
            var cost = Convert.ToDouble(price) * time;
            txtDailyCost.Text = cost.ToString("0.00");

            dataGridViewAllRent.Rows.Add(txtVehicle.Text, txtUserRenter.Text, txtDailyCost.Text);

            ClearFormRent();
            /*try
            {
                RentVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }*/
        }

        private void btnCancelRentVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormRent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewAllRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            try
            {
                SetTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private void ClearFormRent()
        {
            txtVehicle.Text = string.Empty;
            txtUserRenter.Text = string.Empty;
            txtEmployeeBrorrowe.Text = string.Empty;
            dateTimePickerStartDate.Text = string.Empty;
            dateTimePickerEndDate.Text = string.Empty;
            txtDailyCost.Text = string.Empty;
            txtEmployeeTransfee.Text = string.Empty;
            dateTimePickerRequestDate.Text = string.Empty;
        }

        private void SetTime()
        {
            lblDateView.Text = DateTime.Now.ToString();
        }

        private void LoadVehicleInfo()
        {
            lblAllVehicleNo.Text = "0";
            lblRentVevicleNo.Text = "0";
            throw new NotImplementedException();
        }

        private void LoadRentInfo()
        {
            lblAllRentNo.Text = "0";

            throw new NotImplementedException();
        }

        private void LoadUserInfo()
        {
            lblAllUserNo.Text = "0";

            throw new NotImplementedException();
        }

        private void LoadEmployeeInfo()
        {
            lblAllEmployeeNo.Text = "0";

            throw new NotImplementedException();
        }

        private void SearchAllVehicles()
        {
            throw new NotImplementedException();
        }

        private void AddToFavoriteVehicle()
        {
            throw new NotImplementedException();
        }

        private void AddVehicleComment()
        {
            string queryString = "INSERT INTO Comment VALUES ( 'Title','" + txtVehicleComment.Text + "','" + DateTime.Now + "',1," + vehicleId + ")";
            bool status = dbManager.ManageData(queryString);
            vehicleId = 0;
            txtVehicleComment.Text = "";
        }

        private void SearchFavoriteVehicle()
        {
            throw new NotImplementedException();
        }

        private void RemoveFavoriteVehicle()
        {
            throw new NotImplementedException();
        }

        private void RentVehicle()
        {
            throw new NotImplementedException();
        }

        private void dataGridViewAllVehicles_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < dataGridViewAllVehicles.RowCount; i++)
            {
                if (dataGridViewAllVehicles.Rows[i].Selected == true)
                {
                    string id = dataGridViewAllVehicles.Rows[i].Cells["VehicleID"].Value.ToString();
                    vehicleId = Convert.ToInt32(id);

                    FillCarData(Int32.Parse(id));
                    break;
                }
            }
        }
        private void dataGridViewAllVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void FillCarData(int id)
        {
            foreach (var car in cars)
            {
                if (car.vehicleID == id)
                {
                    txtVehicle.Text = car.brand;
                    txtDailyCost.Text = car.price;
                }
            }
        }


    }
}
