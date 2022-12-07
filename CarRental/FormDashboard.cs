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
    public partial class FormDashboard : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlConnection conn = new SqlConnection("data source =(local);initial catalog=MyCarRental;integrated security = true");
        private List<Vehicle> cars = new List<Vehicle>();
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            string loadQuery = "Select Brand, Year, Color, Price, Type FROM Vehicle";
            cmd = new SqlCommand(loadQuery, conn);

            var reader = cmd.ExecuteReader();

            DataTable vehicle = new DataTable();
            vehicle.Load(reader);
            dataGridViewAllVehicles.DataSource = vehicle;
            conn.Close();
            /*try
            {
                SetTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }*/
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
            try
            {
                LoadVehicleInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
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
            adpt = new SqlDataAdapter("Select * from Vehicle Where Brand like '"+txtSearchAllVehicles.Text+"%'", conn);
            DataTable vehicle = new DataTable();
            adpt.Fill(vehicle);
            dataGridViewAllVehicles.DataSource = vehicle;
            conn.Close();

            /*conn.Open();
            string loadQuery = "Select Brand, Year, Color, Price, Type FROM Vehicle";
            cmd = new SqlCommand(loadQuery, conn);

            var reader = cmd.ExecuteReader();

            DataTable vehicle = new DataTable();
            vehicle.Load(reader);
            dataGridViewAllVehicles.DataSource = vehicle;
            conn.Close();*/
            /*try
            {
                SearchAllVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }*/
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
            try
            {
                RentVehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Car Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
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
            lblRentVevicleNo.Text= "0";
            throw new NotImplementedException();
        }

        private void LoadRentInfo()
        {
            lblAllRentNo.Text = "0";
            lblTodayRentNo.Text = "0";
            throw new NotImplementedException();
        }

        private void LoadUserInfo()
        {
            lblAllUserNo.Text = "0";
            lblRentUserNo.Text = "0";
            throw new NotImplementedException();
        }

        private void LoadEmployeeInfo()
        {
            lblAllEmployeeNo.Text = "0";
            lblActiveEmployeeNo.Text = "0";
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
            throw new NotImplementedException();
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

    }
}
