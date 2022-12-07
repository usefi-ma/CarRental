namespace CarRental
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuRentalCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageCar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageVehicleType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserView = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateView = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshVevicleInfo = new System.Windows.Forms.Button();
            this.lblRentVevicleNo = new System.Windows.Forms.Label();
            this.lblRentVevicle = new System.Windows.Forms.Label();
            this.lblAllVehicleNo = new System.Windows.Forms.Label();
            this.lblAllVehicle = new System.Windows.Forms.Label();
            this.groupBoxRentInfo = new System.Windows.Forms.GroupBox();
            this.lblTodayRentNo = new System.Windows.Forms.Label();
            this.lblTodayRent = new System.Windows.Forms.Label();
            this.lblAllRentNo = new System.Windows.Forms.Label();
            this.lblAllRent = new System.Windows.Forms.Label();
            this.btnRefreshRentInfo = new System.Windows.Forms.Button();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblRentUserNo = new System.Windows.Forms.Label();
            this.lblRentUser = new System.Windows.Forms.Label();
            this.lblAllUserNo = new System.Windows.Forms.Label();
            this.lblAllUser = new System.Windows.Forms.Label();
            this.btnRefreshUserInfo = new System.Windows.Forms.Button();
            this.groupBoxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lblActiveEmployeeNo = new System.Windows.Forms.Label();
            this.lblActiveEmployee = new System.Windows.Forms.Label();
            this.lblAllEmployeeNo = new System.Windows.Forms.Label();
            this.lblAllEmployee = new System.Windows.Forms.Label();
            this.btnRefreshEmployeeInfo = new System.Windows.Forms.Button();
            this.groupBoxAllVehicles = new System.Windows.Forms.GroupBox();
            this.btnVehicleComment = new System.Windows.Forms.Button();
            this.txtVehicleComment = new System.Windows.Forms.TextBox();
            this.lblVehicleComment = new System.Windows.Forms.Label();
            this.dataGridViewAllVehicles = new System.Windows.Forms.DataGridView();
            this.btnAddToFavoriteVehicle = new System.Windows.Forms.Button();
            this.btnSearchAllVehicles = new System.Windows.Forms.Button();
            this.txtSearchAllVehicles = new System.Windows.Forms.TextBox();
            this.lblSearchAllVehicles = new System.Windows.Forms.Label();
            this.groupBoxRentVehicle = new System.Windows.Forms.GroupBox();
            this.btnCancelRentVehicle = new System.Windows.Forms.Button();
            this.btnRentVehicle = new System.Windows.Forms.Button();
            this.dateTimePickerRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtEmployeeTransfee = new System.Windows.Forms.TextBox();
            this.lblEmployeeTransfee = new System.Windows.Forms.Label();
            this.txtDailyCost = new System.Windows.Forms.TextBox();
            this.lblDailyCost = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtEmployeeBrorrowe = new System.Windows.Forms.TextBox();
            this.lblEmployeeBrorrowe = new System.Windows.Forms.Label();
            this.txtUserRenter = new System.Windows.Forms.TextBox();
            this.lblUserRenter = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.dataGridViewAllRent = new System.Windows.Forms.DataGridView();
            this.groupBoxFavoriteVehicle = new System.Windows.Forms.GroupBox();
            this.dataGridViewFavoriteVehicle = new System.Windows.Forms.DataGridView();
            this.btnRemoveFavoriteVehicle = new System.Windows.Forms.Button();
            this.btnSerachFavoriteVehicle = new System.Windows.Forms.Button();
            this.txtSerachFavoriteVehicle = new System.Windows.Forms.TextBox();
            this.lblSerachFavoriteVehicle = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxVehicleInfo.SuspendLayout();
            this.groupBoxRentInfo.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.groupBoxEmployeeInfo.SuspendLayout();
            this.groupBoxAllVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllVehicles)).BeginInit();
            this.groupBoxRentVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRent)).BeginInit();
            this.groupBoxFavoriteVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentalCard,
            this.mnuManage,
            this.mnuAbout});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1312, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mnuRentalCard
            // 
            this.mnuRentalCard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentHistory,
            this.mnuExit});
            this.mnuRentalCard.Name = "mnuRentalCard";
            this.mnuRentalCard.Size = new System.Drawing.Size(91, 24);
            this.mnuRentalCard.Text = "Rental Car";
            // 
            // mnuRentHistory
            // 
            this.mnuRentHistory.Image = global::CarRental.Properties.Resources.Order_history_icon;
            this.mnuRentHistory.Name = "mnuRentHistory";
            this.mnuRentHistory.Size = new System.Drawing.Size(173, 26);
            this.mnuRentHistory.Text = "Rent History";
            this.mnuRentHistory.Click += new System.EventHandler(this.mnuRentHistory_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::CarRental.Properties.Resources.Close_icon;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(173, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageCar,
            this.mnuManageVehicleType,
            this.mnuManageUser,
            this.mnuManageEmployee});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(77, 24);
            this.mnuManage.Text = "Manage";
            // 
            // mnuManageCar
            // 
            this.mnuManageCar.Image = global::CarRental.Properties.Resources.Car_icon;
            this.mnuManageCar.Name = "mnuManageCar";
            this.mnuManageCar.Size = new System.Drawing.Size(174, 26);
            this.mnuManageCar.Text = "Vehicle";
            this.mnuManageCar.Click += new System.EventHandler(this.mnuManageCar_Click);
            // 
            // mnuManageVehicleType
            // 
            this.mnuManageVehicleType.Image = global::CarRental.Properties.Resources.car_icon_type;
            this.mnuManageVehicleType.Name = "mnuManageVehicleType";
            this.mnuManageVehicleType.Size = new System.Drawing.Size(174, 26);
            this.mnuManageVehicleType.Text = "Vehicle Type";
            this.mnuManageVehicleType.Click += new System.EventHandler(this.mnuManageVehicleType_Click);
            // 
            // mnuManageUser
            // 
            this.mnuManageUser.Image = global::CarRental.Properties.Resources.Places_user_identity_icon;
            this.mnuManageUser.Name = "mnuManageUser";
            this.mnuManageUser.Size = new System.Drawing.Size(174, 26);
            this.mnuManageUser.Text = "User";
            this.mnuManageUser.Click += new System.EventHandler(this.mnuManageUser_Click);
            // 
            // mnuManageEmployee
            // 
            this.mnuManageEmployee.Image = global::CarRental.Properties.Resources.Office_Customer_Male_Light_icon;
            this.mnuManageEmployee.Name = "mnuManageEmployee";
            this.mnuManageEmployee.Size = new System.Drawing.Size(174, 26);
            this.mnuManageEmployee.Text = "Employee";
            this.mnuManageEmployee.Click += new System.EventHandler(this.mnuManageEmployee_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutForm,
            this.mnuAboutHelp,
            this.mnuAboutTeam});
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(64, 24);
            this.mnuAbout.Text = "About";
            // 
            // mnuAboutForm
            // 
            this.mnuAboutForm.Image = global::CarRental.Properties.Resources.Button_Info_icon;
            this.mnuAboutForm.Name = "mnuAboutForm";
            this.mnuAboutForm.Size = new System.Drawing.Size(205, 26);
            this.mnuAboutForm.Text = "About Car Rental";
            this.mnuAboutForm.Click += new System.EventHandler(this.mnuAboutForm_Click);
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Image = global::CarRental.Properties.Resources.Help_icon;
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(205, 26);
            this.mnuAboutHelp.Text = "Help";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);
            // 
            // mnuAboutTeam
            // 
            this.mnuAboutTeam.Image = global::CarRental.Properties.Resources.User_Group_icon;
            this.mnuAboutTeam.Name = "mnuAboutTeam";
            this.mnuAboutTeam.Size = new System.Drawing.Size(205, 26);
            this.mnuAboutTeam.Text = "Team Member";
            this.mnuAboutTeam.Click += new System.EventHandler(this.mnuAboutTeam_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblUserView,
            this.lblSpace,
            this.lblDate,
            this.lblDateView});
            this.statusStripMain.Location = new System.Drawing.Point(0, 788);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1312, 26);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 20);
            this.lblUser.Text = "User:";
            // 
            // lblUserView
            // 
            this.lblUserView.Name = "lblUserView";
            this.lblUserView.Size = new System.Drawing.Size(73, 20);
            this.lblUserView.Text = "username";
            // 
            // lblSpace
            // 
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(49, 20);
            this.lblSpace.Text = "          ";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.Text = "Date:";
            // 
            // lblDateView
            // 
            this.lblDateView.Name = "lblDateView";
            this.lblDateView.Size = new System.Drawing.Size(44, 20);
            this.lblDateView.Text = "00:00";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // groupBoxVehicleInfo
            // 
            this.groupBoxVehicleInfo.Controls.Add(this.btnRefreshVevicleInfo);
            this.groupBoxVehicleInfo.Controls.Add(this.lblRentVevicleNo);
            this.groupBoxVehicleInfo.Controls.Add(this.lblRentVevicle);
            this.groupBoxVehicleInfo.Controls.Add(this.lblAllVehicleNo);
            this.groupBoxVehicleInfo.Controls.Add(this.lblAllVehicle);
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(16, 33);
            this.groupBoxVehicleInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(316, 123);
            this.groupBoxVehicleInfo.TabIndex = 2;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "Vehicle info";
            // 
            // btnRefreshVevicleInfo
            // 
            this.btnRefreshVevicleInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshVevicleInfo.Image")));
            this.btnRefreshVevicleInfo.Location = new System.Drawing.Point(263, 11);
            this.btnRefreshVevicleInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshVevicleInfo.Name = "btnRefreshVevicleInfo";
            this.btnRefreshVevicleInfo.Size = new System.Drawing.Size(45, 41);
            this.btnRefreshVevicleInfo.TabIndex = 5;
            this.btnRefreshVevicleInfo.UseVisualStyleBackColor = true;
            this.btnRefreshVevicleInfo.Click += new System.EventHandler(this.btnRefreshVevicleInfo_Click);
            // 
            // lblRentVevicleNo
            // 
            this.lblRentVevicleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRentVevicleNo.Location = new System.Drawing.Point(121, 74);
            this.lblRentVevicleNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentVevicleNo.Name = "lblRentVevicleNo";
            this.lblRentVevicleNo.Size = new System.Drawing.Size(87, 18);
            this.lblRentVevicleNo.TabIndex = 4;
            this.lblRentVevicleNo.Text = "0";
            // 
            // lblRentVevicle
            // 
            this.lblRentVevicle.AutoSize = true;
            this.lblRentVevicle.Location = new System.Drawing.Point(20, 74);
            this.lblRentVevicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentVevicle.Name = "lblRentVevicle";
            this.lblRentVevicle.Size = new System.Drawing.Size(84, 16);
            this.lblRentVevicle.TabIndex = 3;
            this.lblRentVevicle.Text = "Rent vehicle:";
            // 
            // lblAllVehicleNo
            // 
            this.lblAllVehicleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllVehicleNo.Location = new System.Drawing.Point(121, 41);
            this.lblAllVehicleNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllVehicleNo.Name = "lblAllVehicleNo";
            this.lblAllVehicleNo.Size = new System.Drawing.Size(87, 18);
            this.lblAllVehicleNo.TabIndex = 2;
            this.lblAllVehicleNo.Text = "0";
            // 
            // lblAllVehicle
            // 
            this.lblAllVehicle.AutoSize = true;
            this.lblAllVehicle.Location = new System.Drawing.Point(36, 41);
            this.lblAllVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllVehicle.Name = "lblAllVehicle";
            this.lblAllVehicle.Size = new System.Drawing.Size(71, 16);
            this.lblAllVehicle.TabIndex = 1;
            this.lblAllVehicle.Text = "All vehicle:";
            // 
            // groupBoxRentInfo
            // 
            this.groupBoxRentInfo.Controls.Add(this.lblTodayRentNo);
            this.groupBoxRentInfo.Controls.Add(this.lblTodayRent);
            this.groupBoxRentInfo.Controls.Add(this.lblAllRentNo);
            this.groupBoxRentInfo.Controls.Add(this.lblAllRent);
            this.groupBoxRentInfo.Controls.Add(this.btnRefreshRentInfo);
            this.groupBoxRentInfo.Location = new System.Drawing.Point(340, 33);
            this.groupBoxRentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRentInfo.Name = "groupBoxRentInfo";
            this.groupBoxRentInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRentInfo.Size = new System.Drawing.Size(316, 123);
            this.groupBoxRentInfo.TabIndex = 3;
            this.groupBoxRentInfo.TabStop = false;
            this.groupBoxRentInfo.Text = "Rent info";
            // 
            // lblTodayRentNo
            // 
            this.lblTodayRentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTodayRentNo.Location = new System.Drawing.Point(109, 74);
            this.lblTodayRentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayRentNo.Name = "lblTodayRentNo";
            this.lblTodayRentNo.Size = new System.Drawing.Size(87, 18);
            this.lblTodayRentNo.TabIndex = 8;
            this.lblTodayRentNo.Text = "0";
            // 
            // lblTodayRent
            // 
            this.lblTodayRent.AutoSize = true;
            this.lblTodayRent.Location = new System.Drawing.Point(20, 75);
            this.lblTodayRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayRent.Name = "lblTodayRent";
            this.lblTodayRent.Size = new System.Drawing.Size(75, 16);
            this.lblTodayRent.TabIndex = 7;
            this.lblTodayRent.Text = "Today rent:";
            // 
            // lblAllRentNo
            // 
            this.lblAllRentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllRentNo.Location = new System.Drawing.Point(109, 41);
            this.lblAllRentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllRentNo.Name = "lblAllRentNo";
            this.lblAllRentNo.Size = new System.Drawing.Size(87, 18);
            this.lblAllRentNo.TabIndex = 6;
            this.lblAllRentNo.Text = "0";
            // 
            // lblAllRent
            // 
            this.lblAllRent.AutoSize = true;
            this.lblAllRent.Location = new System.Drawing.Point(45, 42);
            this.lblAllRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllRent.Name = "lblAllRent";
            this.lblAllRent.Size = new System.Drawing.Size(50, 16);
            this.lblAllRent.TabIndex = 5;
            this.lblAllRent.Text = "All rent:";
            // 
            // btnRefreshRentInfo
            // 
            this.btnRefreshRentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshRentInfo.Image")));
            this.btnRefreshRentInfo.Location = new System.Drawing.Point(263, 11);
            this.btnRefreshRentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshRentInfo.Name = "btnRefreshRentInfo";
            this.btnRefreshRentInfo.Size = new System.Drawing.Size(45, 41);
            this.btnRefreshRentInfo.TabIndex = 4;
            this.btnRefreshRentInfo.UseVisualStyleBackColor = true;
            this.btnRefreshRentInfo.Click += new System.EventHandler(this.btnRefreshRentInfo_Click);
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.lblRentUserNo);
            this.groupBoxUserInfo.Controls.Add(this.lblRentUser);
            this.groupBoxUserInfo.Controls.Add(this.lblAllUserNo);
            this.groupBoxUserInfo.Controls.Add(this.lblAllUser);
            this.groupBoxUserInfo.Controls.Add(this.btnRefreshUserInfo);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(664, 33);
            this.groupBoxUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserInfo.Size = new System.Drawing.Size(316, 123);
            this.groupBoxUserInfo.TabIndex = 4;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User info";
            // 
            // lblRentUserNo
            // 
            this.lblRentUserNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRentUserNo.Location = new System.Drawing.Point(97, 75);
            this.lblRentUserNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentUserNo.Name = "lblRentUserNo";
            this.lblRentUserNo.Size = new System.Drawing.Size(87, 18);
            this.lblRentUserNo.TabIndex = 8;
            this.lblRentUserNo.Text = "0";
            // 
            // lblRentUser
            // 
            this.lblRentUser.AutoSize = true;
            this.lblRentUser.Location = new System.Drawing.Point(15, 78);
            this.lblRentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentUser.Name = "lblRentUser";
            this.lblRentUser.Size = new System.Drawing.Size(67, 16);
            this.lblRentUser.TabIndex = 7;
            this.lblRentUser.Text = "Rent user:";
            // 
            // lblAllUserNo
            // 
            this.lblAllUserNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllUserNo.Location = new System.Drawing.Point(97, 42);
            this.lblAllUserNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllUserNo.Name = "lblAllUserNo";
            this.lblAllUserNo.Size = new System.Drawing.Size(87, 18);
            this.lblAllUserNo.TabIndex = 6;
            this.lblAllUserNo.Text = "0";
            // 
            // lblAllUser
            // 
            this.lblAllUser.AutoSize = true;
            this.lblAllUser.Location = new System.Drawing.Point(31, 43);
            this.lblAllUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllUser.Name = "lblAllUser";
            this.lblAllUser.Size = new System.Drawing.Size(54, 16);
            this.lblAllUser.TabIndex = 5;
            this.lblAllUser.Text = "All user:";
            // 
            // btnRefreshUserInfo
            // 
            this.btnRefreshUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshUserInfo.Image")));
            this.btnRefreshUserInfo.Location = new System.Drawing.Point(263, 11);
            this.btnRefreshUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshUserInfo.Name = "btnRefreshUserInfo";
            this.btnRefreshUserInfo.Size = new System.Drawing.Size(45, 41);
            this.btnRefreshUserInfo.TabIndex = 4;
            this.btnRefreshUserInfo.UseVisualStyleBackColor = true;
            this.btnRefreshUserInfo.Click += new System.EventHandler(this.btnRefreshUserInfo_Click);
            // 
            // groupBoxEmployeeInfo
            // 
            this.groupBoxEmployeeInfo.Controls.Add(this.lblActiveEmployeeNo);
            this.groupBoxEmployeeInfo.Controls.Add(this.lblActiveEmployee);
            this.groupBoxEmployeeInfo.Controls.Add(this.lblAllEmployeeNo);
            this.groupBoxEmployeeInfo.Controls.Add(this.lblAllEmployee);
            this.groupBoxEmployeeInfo.Controls.Add(this.btnRefreshEmployeeInfo);
            this.groupBoxEmployeeInfo.Location = new System.Drawing.Point(988, 33);
            this.groupBoxEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEmployeeInfo.Name = "groupBoxEmployeeInfo";
            this.groupBoxEmployeeInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEmployeeInfo.Size = new System.Drawing.Size(316, 123);
            this.groupBoxEmployeeInfo.TabIndex = 5;
            this.groupBoxEmployeeInfo.TabStop = false;
            this.groupBoxEmployeeInfo.Text = "Employee info";
            // 
            // lblActiveEmployeeNo
            // 
            this.lblActiveEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActiveEmployeeNo.Location = new System.Drawing.Point(145, 75);
            this.lblActiveEmployeeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveEmployeeNo.Name = "lblActiveEmployeeNo";
            this.lblActiveEmployeeNo.Size = new System.Drawing.Size(87, 18);
            this.lblActiveEmployeeNo.TabIndex = 8;
            this.lblActiveEmployeeNo.Text = "0";
            // 
            // lblActiveEmployee
            // 
            this.lblActiveEmployee.AutoSize = true;
            this.lblActiveEmployee.Location = new System.Drawing.Point(20, 76);
            this.lblActiveEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveEmployee.Name = "lblActiveEmployee";
            this.lblActiveEmployee.Size = new System.Drawing.Size(111, 16);
            this.lblActiveEmployee.TabIndex = 7;
            this.lblActiveEmployee.Text = "Active employee:";
            // 
            // lblAllEmployeeNo
            // 
            this.lblAllEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllEmployeeNo.Location = new System.Drawing.Point(145, 42);
            this.lblAllEmployeeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllEmployeeNo.Name = "lblAllEmployeeNo";
            this.lblAllEmployeeNo.Size = new System.Drawing.Size(87, 18);
            this.lblAllEmployeeNo.TabIndex = 6;
            this.lblAllEmployeeNo.Text = "0";
            // 
            // lblAllEmployee
            // 
            this.lblAllEmployee.AutoSize = true;
            this.lblAllEmployee.Location = new System.Drawing.Point(45, 44);
            this.lblAllEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllEmployee.Name = "lblAllEmployee";
            this.lblAllEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblAllEmployee.TabIndex = 5;
            this.lblAllEmployee.Text = "All employee:";
            // 
            // btnRefreshEmployeeInfo
            // 
            this.btnRefreshEmployeeInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmployeeInfo.Image")));
            this.btnRefreshEmployeeInfo.Location = new System.Drawing.Point(263, 11);
            this.btnRefreshEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshEmployeeInfo.Name = "btnRefreshEmployeeInfo";
            this.btnRefreshEmployeeInfo.Size = new System.Drawing.Size(45, 41);
            this.btnRefreshEmployeeInfo.TabIndex = 4;
            this.btnRefreshEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnRefreshEmployeeInfo.Click += new System.EventHandler(this.btnRefreshEmployeeInfo_Click);
            // 
            // groupBoxAllVehicles
            // 
            this.groupBoxAllVehicles.Controls.Add(this.btnVehicleComment);
            this.groupBoxAllVehicles.Controls.Add(this.txtVehicleComment);
            this.groupBoxAllVehicles.Controls.Add(this.lblVehicleComment);
            this.groupBoxAllVehicles.Controls.Add(this.dataGridViewAllVehicles);
            this.groupBoxAllVehicles.Controls.Add(this.btnAddToFavoriteVehicle);
            this.groupBoxAllVehicles.Controls.Add(this.btnSearchAllVehicles);
            this.groupBoxAllVehicles.Controls.Add(this.txtSearchAllVehicles);
            this.groupBoxAllVehicles.Controls.Add(this.lblSearchAllVehicles);
            this.groupBoxAllVehicles.Location = new System.Drawing.Point(16, 164);
            this.groupBoxAllVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAllVehicles.Name = "groupBoxAllVehicles";
            this.groupBoxAllVehicles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAllVehicles.Size = new System.Drawing.Size(640, 364);
            this.groupBoxAllVehicles.TabIndex = 6;
            this.groupBoxAllVehicles.TabStop = false;
            this.groupBoxAllVehicles.Text = "All Vehicles";
            // 
            // btnVehicleComment
            // 
            this.btnVehicleComment.Location = new System.Drawing.Point(511, 325);
            this.btnVehicleComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVehicleComment.Name = "btnVehicleComment";
            this.btnVehicleComment.Size = new System.Drawing.Size(121, 28);
            this.btnVehicleComment.TabIndex = 7;
            this.btnVehicleComment.Text = "Add Comment";
            this.btnVehicleComment.UseVisualStyleBackColor = true;
            this.btnVehicleComment.Click += new System.EventHandler(this.btnVehicleComment_Click);
            // 
            // txtVehicleComment
            // 
            this.txtVehicleComment.Location = new System.Drawing.Point(87, 327);
            this.txtVehicleComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVehicleComment.Name = "txtVehicleComment";
            this.txtVehicleComment.Size = new System.Drawing.Size(415, 22);
            this.txtVehicleComment.TabIndex = 6;
            // 
            // lblVehicleComment
            // 
            this.lblVehicleComment.AutoSize = true;
            this.lblVehicleComment.Location = new System.Drawing.Point(8, 331);
            this.lblVehicleComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleComment.Name = "lblVehicleComment";
            this.lblVehicleComment.Size = new System.Drawing.Size(67, 16);
            this.lblVehicleComment.TabIndex = 5;
            this.lblVehicleComment.Text = "Comment:";
            // 
            // dataGridViewAllVehicles
            // 
            this.dataGridViewAllVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllVehicles.Location = new System.Drawing.Point(8, 59);
            this.dataGridViewAllVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAllVehicles.Name = "dataGridViewAllVehicles";
            this.dataGridViewAllVehicles.RowHeadersWidth = 51;
            this.dataGridViewAllVehicles.Size = new System.Drawing.Size(624, 258);
            this.dataGridViewAllVehicles.TabIndex = 4;
            this.dataGridViewAllVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllVehicles_CellContentClick);
            // 
            // btnAddToFavoriteVehicle
            // 
            this.btnAddToFavoriteVehicle.Image = global::CarRental.Properties.Resources.favourites_icon;
            this.btnAddToFavoriteVehicle.Location = new System.Drawing.Point(587, 14);
            this.btnAddToFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToFavoriteVehicle.Name = "btnAddToFavoriteVehicle";
            this.btnAddToFavoriteVehicle.Size = new System.Drawing.Size(45, 41);
            this.btnAddToFavoriteVehicle.TabIndex = 3;
            this.btnAddToFavoriteVehicle.UseVisualStyleBackColor = true;
            this.btnAddToFavoriteVehicle.Click += new System.EventHandler(this.btnAddToFavoriteVehicle_Click);
            // 
            // btnSearchAllVehicles
            // 
            this.btnSearchAllVehicles.Location = new System.Drawing.Point(468, 20);
            this.btnSearchAllVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchAllVehicles.Name = "btnSearchAllVehicles";
            this.btnSearchAllVehicles.Size = new System.Drawing.Size(100, 28);
            this.btnSearchAllVehicles.TabIndex = 2;
            this.btnSearchAllVehicles.Text = "Search";
            this.btnSearchAllVehicles.UseVisualStyleBackColor = true;
            this.btnSearchAllVehicles.Click += new System.EventHandler(this.btnSearchAllVehicles_Click);
            // 
            // txtSearchAllVehicles
            // 
            this.txtSearchAllVehicles.Location = new System.Drawing.Point(87, 22);
            this.txtSearchAllVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchAllVehicles.Name = "txtSearchAllVehicles";
            this.txtSearchAllVehicles.Size = new System.Drawing.Size(372, 22);
            this.txtSearchAllVehicles.TabIndex = 1;
            // 
            // lblSearchAllVehicles
            // 
            this.lblSearchAllVehicles.AutoSize = true;
            this.lblSearchAllVehicles.Location = new System.Drawing.Point(20, 26);
            this.lblSearchAllVehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchAllVehicles.Name = "lblSearchAllVehicles";
            this.lblSearchAllVehicles.Size = new System.Drawing.Size(53, 16);
            this.lblSearchAllVehicles.TabIndex = 0;
            this.lblSearchAllVehicles.Text = "Search:";
            // 
            // groupBoxRentVehicle
            // 
            this.groupBoxRentVehicle.Controls.Add(this.btnCancelRentVehicle);
            this.groupBoxRentVehicle.Controls.Add(this.btnRentVehicle);
            this.groupBoxRentVehicle.Controls.Add(this.dateTimePickerRequestDate);
            this.groupBoxRentVehicle.Controls.Add(this.lblRequestDate);
            this.groupBoxRentVehicle.Controls.Add(this.txtEmployeeTransfee);
            this.groupBoxRentVehicle.Controls.Add(this.lblEmployeeTransfee);
            this.groupBoxRentVehicle.Controls.Add(this.txtDailyCost);
            this.groupBoxRentVehicle.Controls.Add(this.lblDailyCost);
            this.groupBoxRentVehicle.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxRentVehicle.Controls.Add(this.lblEndDate);
            this.groupBoxRentVehicle.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxRentVehicle.Controls.Add(this.lblStartDate);
            this.groupBoxRentVehicle.Controls.Add(this.txtEmployeeBrorrowe);
            this.groupBoxRentVehicle.Controls.Add(this.lblEmployeeBrorrowe);
            this.groupBoxRentVehicle.Controls.Add(this.txtUserRenter);
            this.groupBoxRentVehicle.Controls.Add(this.lblUserRenter);
            this.groupBoxRentVehicle.Controls.Add(this.txtVehicle);
            this.groupBoxRentVehicle.Controls.Add(this.lblVehicle);
            this.groupBoxRentVehicle.Controls.Add(this.dataGridViewAllRent);
            this.groupBoxRentVehicle.Location = new System.Drawing.Point(664, 164);
            this.groupBoxRentVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRentVehicle.Name = "groupBoxRentVehicle";
            this.groupBoxRentVehicle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRentVehicle.Size = new System.Drawing.Size(640, 619);
            this.groupBoxRentVehicle.TabIndex = 7;
            this.groupBoxRentVehicle.TabStop = false;
            this.groupBoxRentVehicle.Text = "Rent Vehicle";
            // 
            // btnCancelRentVehicle
            // 
            this.btnCancelRentVehicle.Location = new System.Drawing.Point(425, 273);
            this.btnCancelRentVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelRentVehicle.Name = "btnCancelRentVehicle";
            this.btnCancelRentVehicle.Size = new System.Drawing.Size(100, 28);
            this.btnCancelRentVehicle.TabIndex = 28;
            this.btnCancelRentVehicle.Text = "Cancel";
            this.btnCancelRentVehicle.UseVisualStyleBackColor = true;
            this.btnCancelRentVehicle.Click += new System.EventHandler(this.btnCancelRentVehicle_Click);
            // 
            // btnRentVehicle
            // 
            this.btnRentVehicle.Location = new System.Drawing.Point(152, 273);
            this.btnRentVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRentVehicle.Name = "btnRentVehicle";
            this.btnRentVehicle.Size = new System.Drawing.Size(100, 28);
            this.btnRentVehicle.TabIndex = 27;
            this.btnRentVehicle.Text = "Renting";
            this.btnRentVehicle.UseVisualStyleBackColor = true;
            this.btnRentVehicle.Click += new System.EventHandler(this.btnRentVehicle_Click);
            // 
            // dateTimePickerRequestDate
            // 
            this.dateTimePickerRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRequestDate.Location = new System.Drawing.Point(152, 241);
            this.dateTimePickerRequestDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            this.dateTimePickerRequestDate.Size = new System.Drawing.Size(163, 22);
            this.dateTimePickerRequestDate.TabIndex = 26;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(43, 249);
            this.lblRequestDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(93, 16);
            this.lblRequestDate.TabIndex = 25;
            this.lblRequestDate.Text = "Request Date:";
            // 
            // txtEmployeeTransfee
            // 
            this.txtEmployeeTransfee.Location = new System.Drawing.Point(152, 209);
            this.txtEmployeeTransfee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeTransfee.Name = "txtEmployeeTransfee";
            this.txtEmployeeTransfee.Size = new System.Drawing.Size(372, 22);
            this.txtEmployeeTransfee.TabIndex = 24;
            // 
            // lblEmployeeTransfee
            // 
            this.lblEmployeeTransfee.AutoSize = true;
            this.lblEmployeeTransfee.Location = new System.Drawing.Point(15, 213);
            this.lblEmployeeTransfee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeTransfee.Name = "lblEmployeeTransfee";
            this.lblEmployeeTransfee.Size = new System.Drawing.Size(123, 16);
            this.lblEmployeeTransfee.TabIndex = 23;
            this.lblEmployeeTransfee.Text = "Employee transfee:";
            // 
            // txtDailyCost
            // 
            this.txtDailyCost.Location = new System.Drawing.Point(152, 177);
            this.txtDailyCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDailyCost.Name = "txtDailyCost";
            this.txtDailyCost.Size = new System.Drawing.Size(163, 22);
            this.txtDailyCost.TabIndex = 22;
            // 
            // lblDailyCost
            // 
            this.lblDailyCost.AutoSize = true;
            this.lblDailyCost.Location = new System.Drawing.Point(68, 181);
            this.lblDailyCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyCost.Name = "lblDailyCost";
            this.lblDailyCost.Size = new System.Drawing.Size(71, 16);
            this.lblDailyCost.TabIndex = 21;
            this.lblDailyCost.Text = "Daily Cost:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(152, 145);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(163, 22);
            this.dateTimePickerEndDate.TabIndex = 20;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(71, 149);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 16);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "End Date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(152, 112);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(163, 22);
            this.dateTimePickerStartDate.TabIndex = 18;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(67, 116);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Strat Date:";
            // 
            // txtEmployeeBrorrowe
            // 
            this.txtEmployeeBrorrowe.Location = new System.Drawing.Point(152, 80);
            this.txtEmployeeBrorrowe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeBrorrowe.Name = "txtEmployeeBrorrowe";
            this.txtEmployeeBrorrowe.Size = new System.Drawing.Size(372, 22);
            this.txtEmployeeBrorrowe.TabIndex = 16;
            // 
            // lblEmployeeBrorrowe
            // 
            this.lblEmployeeBrorrowe.AutoSize = true;
            this.lblEmployeeBrorrowe.Location = new System.Drawing.Point(15, 84);
            this.lblEmployeeBrorrowe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeBrorrowe.Name = "lblEmployeeBrorrowe";
            this.lblEmployeeBrorrowe.Size = new System.Drawing.Size(124, 16);
            this.lblEmployeeBrorrowe.TabIndex = 15;
            this.lblEmployeeBrorrowe.Text = "Employee borrowe:";
            // 
            // txtUserRenter
            // 
            this.txtUserRenter.Location = new System.Drawing.Point(152, 48);
            this.txtUserRenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserRenter.Name = "txtUserRenter";
            this.txtUserRenter.Size = new System.Drawing.Size(372, 22);
            this.txtUserRenter.TabIndex = 14;
            // 
            // lblUserRenter
            // 
            this.lblUserRenter.AutoSize = true;
            this.lblUserRenter.Location = new System.Drawing.Point(61, 52);
            this.lblUserRenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRenter.Name = "lblUserRenter";
            this.lblUserRenter.Size = new System.Drawing.Size(76, 16);
            this.lblUserRenter.TabIndex = 13;
            this.lblUserRenter.Text = "User renter:";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(152, 16);
            this.txtVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(372, 22);
            this.txtVehicle.TabIndex = 12;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(84, 20);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(55, 16);
            this.lblVehicle.TabIndex = 11;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // dataGridViewAllRent
            // 
            this.dataGridViewAllRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllRent.Location = new System.Drawing.Point(8, 309);
            this.dataGridViewAllRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAllRent.Name = "dataGridViewAllRent";
            this.dataGridViewAllRent.RowHeadersWidth = 51;
            this.dataGridViewAllRent.Size = new System.Drawing.Size(624, 295);
            this.dataGridViewAllRent.TabIndex = 10;
            this.dataGridViewAllRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllRent_CellContentClick);
            // 
            // groupBoxFavoriteVehicle
            // 
            this.groupBoxFavoriteVehicle.Controls.Add(this.dataGridViewFavoriteVehicle);
            this.groupBoxFavoriteVehicle.Controls.Add(this.btnRemoveFavoriteVehicle);
            this.groupBoxFavoriteVehicle.Controls.Add(this.btnSerachFavoriteVehicle);
            this.groupBoxFavoriteVehicle.Controls.Add(this.txtSerachFavoriteVehicle);
            this.groupBoxFavoriteVehicle.Controls.Add(this.lblSerachFavoriteVehicle);
            this.groupBoxFavoriteVehicle.Location = new System.Drawing.Point(16, 535);
            this.groupBoxFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFavoriteVehicle.Name = "groupBoxFavoriteVehicle";
            this.groupBoxFavoriteVehicle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFavoriteVehicle.Size = new System.Drawing.Size(640, 247);
            this.groupBoxFavoriteVehicle.TabIndex = 8;
            this.groupBoxFavoriteVehicle.TabStop = false;
            this.groupBoxFavoriteVehicle.Text = "User Favorite Vehicles";
            // 
            // dataGridViewFavoriteVehicle
            // 
            this.dataGridViewFavoriteVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavoriteVehicle.Location = new System.Drawing.Point(8, 63);
            this.dataGridViewFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFavoriteVehicle.Name = "dataGridViewFavoriteVehicle";
            this.dataGridViewFavoriteVehicle.RowHeadersWidth = 51;
            this.dataGridViewFavoriteVehicle.Size = new System.Drawing.Size(624, 174);
            this.dataGridViewFavoriteVehicle.TabIndex = 9;
            this.dataGridViewFavoriteVehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavoriteVehicle_CellContentClick);
            // 
            // btnRemoveFavoriteVehicle
            // 
            this.btnRemoveFavoriteVehicle.Image = global::CarRental.Properties.Resources.Remove_icon;
            this.btnRemoveFavoriteVehicle.Location = new System.Drawing.Point(587, 15);
            this.btnRemoveFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFavoriteVehicle.Name = "btnRemoveFavoriteVehicle";
            this.btnRemoveFavoriteVehicle.Size = new System.Drawing.Size(45, 41);
            this.btnRemoveFavoriteVehicle.TabIndex = 8;
            this.btnRemoveFavoriteVehicle.UseVisualStyleBackColor = true;
            this.btnRemoveFavoriteVehicle.Click += new System.EventHandler(this.btnRemoveFavoriteVehicle_Click);
            // 
            // btnSerachFavoriteVehicle
            // 
            this.btnSerachFavoriteVehicle.Location = new System.Drawing.Point(468, 21);
            this.btnSerachFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerachFavoriteVehicle.Name = "btnSerachFavoriteVehicle";
            this.btnSerachFavoriteVehicle.Size = new System.Drawing.Size(100, 28);
            this.btnSerachFavoriteVehicle.TabIndex = 7;
            this.btnSerachFavoriteVehicle.Text = "Search";
            this.btnSerachFavoriteVehicle.UseVisualStyleBackColor = true;
            this.btnSerachFavoriteVehicle.Click += new System.EventHandler(this.btnSerachFavoriteVehicle_Click);
            // 
            // txtSerachFavoriteVehicle
            // 
            this.txtSerachFavoriteVehicle.Location = new System.Drawing.Point(87, 23);
            this.txtSerachFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerachFavoriteVehicle.Name = "txtSerachFavoriteVehicle";
            this.txtSerachFavoriteVehicle.Size = new System.Drawing.Size(372, 22);
            this.txtSerachFavoriteVehicle.TabIndex = 6;
            // 
            // lblSerachFavoriteVehicle
            // 
            this.lblSerachFavoriteVehicle.AutoSize = true;
            this.lblSerachFavoriteVehicle.Location = new System.Drawing.Point(20, 27);
            this.lblSerachFavoriteVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerachFavoriteVehicle.Name = "lblSerachFavoriteVehicle";
            this.lblSerachFavoriteVehicle.Size = new System.Drawing.Size(53, 16);
            this.lblSerachFavoriteVehicle.TabIndex = 5;
            this.lblSerachFavoriteVehicle.Text = "Search:";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.groupBoxFavoriteVehicle);
            this.Controls.Add(this.groupBoxRentVehicle);
            this.Controls.Add(this.groupBoxAllVehicles);
            this.Controls.Add(this.groupBoxEmployeeInfo);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.groupBoxRentInfo);
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxVehicleInfo.ResumeLayout(false);
            this.groupBoxVehicleInfo.PerformLayout();
            this.groupBoxRentInfo.ResumeLayout(false);
            this.groupBoxRentInfo.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.groupBoxEmployeeInfo.ResumeLayout(false);
            this.groupBoxEmployeeInfo.PerformLayout();
            this.groupBoxAllVehicles.ResumeLayout(false);
            this.groupBoxAllVehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllVehicles)).EndInit();
            this.groupBoxRentVehicle.ResumeLayout(false);
            this.groupBoxRentVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRent)).EndInit();
            this.groupBoxFavoriteVehicle.ResumeLayout(false);
            this.groupBoxFavoriteVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRentalCard;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutForm;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblDateView;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRentHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuManageCar;
        private System.Windows.Forms.ToolStripMenuItem mnuManageUser;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblUserView;
        private System.Windows.Forms.ToolStripStatusLabel lblSpace;
        private System.Windows.Forms.ToolStripMenuItem mnuManageEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.GroupBox groupBoxRentInfo;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.GroupBox groupBoxEmployeeInfo;
        private System.Windows.Forms.GroupBox groupBoxAllVehicles;
        private System.Windows.Forms.GroupBox groupBoxRentVehicle;
        private System.Windows.Forms.GroupBox groupBoxFavoriteVehicle;
        private System.Windows.Forms.Button btnAddToFavoriteVehicle;
        private System.Windows.Forms.Button btnSearchAllVehicles;
        private System.Windows.Forms.TextBox txtSearchAllVehicles;
        private System.Windows.Forms.Label lblSearchAllVehicles;
        private System.Windows.Forms.DataGridView dataGridViewAllVehicles;
        private System.Windows.Forms.DataGridView dataGridViewFavoriteVehicle;
        private System.Windows.Forms.Button btnRemoveFavoriteVehicle;
        private System.Windows.Forms.Button btnSerachFavoriteVehicle;
        private System.Windows.Forms.TextBox txtSerachFavoriteVehicle;
        private System.Windows.Forms.Label lblSerachFavoriteVehicle;
        private System.Windows.Forms.DataGridView dataGridViewAllRent;
        private System.Windows.Forms.TextBox txtEmployeeBrorrowe;
        private System.Windows.Forms.Label lblEmployeeBrorrowe;
        private System.Windows.Forms.TextBox txtUserRenter;
        private System.Windows.Forms.Label lblUserRenter;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtDailyCost;
        private System.Windows.Forms.Label lblDailyCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtEmployeeTransfee;
        private System.Windows.Forms.Label lblEmployeeTransfee;
        private System.Windows.Forms.Button btnCancelRentVehicle;
        private System.Windows.Forms.Button btnRentVehicle;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequestDate;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblRentVevicleNo;
        private System.Windows.Forms.Label lblRentVevicle;
        private System.Windows.Forms.Label lblAllVehicleNo;
        private System.Windows.Forms.Label lblAllVehicle;
        private System.Windows.Forms.Button btnRefreshVevicleInfo;
        private System.Windows.Forms.Label lblTodayRentNo;
        private System.Windows.Forms.Label lblTodayRent;
        private System.Windows.Forms.Label lblAllRentNo;
        private System.Windows.Forms.Label lblAllRent;
        private System.Windows.Forms.Button btnRefreshRentInfo;
        private System.Windows.Forms.Label lblRentUserNo;
        private System.Windows.Forms.Label lblRentUser;
        private System.Windows.Forms.Label lblAllUserNo;
        private System.Windows.Forms.Label lblAllUser;
        private System.Windows.Forms.Button btnRefreshUserInfo;
        private System.Windows.Forms.Label lblActiveEmployeeNo;
        private System.Windows.Forms.Label lblActiveEmployee;
        private System.Windows.Forms.Label lblAllEmployeeNo;
        private System.Windows.Forms.Label lblAllEmployee;
        private System.Windows.Forms.Button btnRefreshEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuManageVehicleType;
        private System.Windows.Forms.Button btnVehicleComment;
        private System.Windows.Forms.TextBox txtVehicleComment;
        private System.Windows.Forms.Label lblVehicleComment;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutTeam;
    }
}