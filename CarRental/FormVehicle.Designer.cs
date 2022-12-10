namespace CarRental
{
    partial class FormVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicle));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.comboBoxIsDeleted = new System.Windows.Forms.ComboBox();
            this.lblIsDeleted = new System.Windows.Forms.Label();
            this.comboBoxIsRented = new System.Windows.Forms.ComboBox();
            this.lblIsRented = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblCountItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountItemNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.lblImageList = new System.Windows.Forms.Label();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.listViewComments = new System.Windows.Forms.ListView();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.groupBoxMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.btnCancel);
            this.groupBoxMain.Controls.Add(this.dateTimePickerRegisterDate);
            this.groupBoxMain.Controls.Add(this.lblRegisterDate);
            this.groupBoxMain.Controls.Add(this.comboBoxIsDeleted);
            this.groupBoxMain.Controls.Add(this.lblIsDeleted);
            this.groupBoxMain.Controls.Add(this.comboBoxIsRented);
            this.groupBoxMain.Controls.Add(this.lblIsRented);
            this.groupBoxMain.Controls.Add(this.txtPrice);
            this.groupBoxMain.Controls.Add(this.lblPrice);
            this.groupBoxMain.Controls.Add(this.txtColor);
            this.groupBoxMain.Controls.Add(this.lblColor);
            this.groupBoxMain.Controls.Add(this.txtYear);
            this.groupBoxMain.Controls.Add(this.lblYear);
            this.groupBoxMain.Controls.Add(this.txtBrand);
            this.groupBoxMain.Controls.Add(this.btnSearch);
            this.groupBoxMain.Controls.Add(this.btnDelete);
            this.groupBoxMain.Controls.Add(this.btnEdit);
            this.groupBoxMain.Controls.Add(this.btnSave);
            this.groupBoxMain.Controls.Add(this.comboBoxVehicleType);
            this.groupBoxMain.Controls.Add(this.lblVehicleType);
            this.groupBoxMain.Controls.Add(this.txtID);
            this.groupBoxMain.Controls.Add(this.lblID);
            this.groupBoxMain.Controls.Add(this.lblBrand);
            this.groupBoxMain.Location = new System.Drawing.Point(16, 15);
            this.groupBoxMain.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMain.Size = new System.Drawing.Size(800, 240);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Employee info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(525, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(515, 160);
            this.dateTimePickerRegisterDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(217, 22);
            this.dateTimePickerRegisterDate.TabIndex = 22;
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(409, 165);
            this.lblRegisterDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(91, 16);
            this.lblRegisterDate.TabIndex = 21;
            this.lblRegisterDate.Text = "Register date:";
            // 
            // comboBoxIsDeleted
            // 
            this.comboBoxIsDeleted.FormattingEnabled = true;
            this.comboBoxIsDeleted.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxIsDeleted.Location = new System.Drawing.Point(515, 127);
            this.comboBoxIsDeleted.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIsDeleted.Name = "comboBoxIsDeleted";
            this.comboBoxIsDeleted.Size = new System.Drawing.Size(105, 24);
            this.comboBoxIsDeleted.TabIndex = 20;
            // 
            // lblIsDeleted
            // 
            this.lblIsDeleted.AutoSize = true;
            this.lblIsDeleted.Location = new System.Drawing.Point(429, 130);
            this.lblIsDeleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsDeleted.Name = "lblIsDeleted";
            this.lblIsDeleted.Size = new System.Drawing.Size(71, 16);
            this.lblIsDeleted.TabIndex = 19;
            this.lblIsDeleted.Text = "Is Deleted:";
            // 
            // comboBoxIsRented
            // 
            this.comboBoxIsRented.FormattingEnabled = true;
            this.comboBoxIsRented.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxIsRented.Location = new System.Drawing.Point(515, 94);
            this.comboBoxIsRented.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIsRented.Name = "comboBoxIsRented";
            this.comboBoxIsRented.Size = new System.Drawing.Size(105, 24);
            this.comboBoxIsRented.TabIndex = 18;
            // 
            // lblIsRented
            // 
            this.lblIsRented.AutoSize = true;
            this.lblIsRented.Location = new System.Drawing.Point(439, 97);
            this.lblIsRented.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsRented.Name = "lblIsRented";
            this.lblIsRented.Size = new System.Drawing.Size(61, 16);
            this.lblIsRented.TabIndex = 17;
            this.lblIsRented.Text = "Is rented:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 156);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 22);
            this.txtPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(41, 160);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(100, 124);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(207, 22);
            this.txtColor.TabIndex = 14;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(41, 128);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 16);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 92);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(207, 22);
            this.txtYear.TabIndex = 12;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(41, 96);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Year:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(100, 60);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(207, 22);
            this.txtBrand.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(633, 199);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 199);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 199);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(515, 60);
            this.comboBoxVehicleType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(217, 24);
            this.comboBoxVehicleType.TabIndex = 5;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(461, 64);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(42, 16);
            this.lblVehicleType.TabIndex = 4;
            this.lblVehicleType.Text = "Type:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(100, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(83, 22);
            this.txtID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(64, 32);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(41, 64);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 16);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand:";
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCountItem,
            this.lblCountItemNo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 664);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1045, 26);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblCountItem
            // 
            this.lblCountItem.Name = "lblCountItem";
            this.lblCountItem.Size = new System.Drawing.Size(85, 20);
            this.lblCountItem.Text = "Item Count:";
            // 
            // lblCountItemNo
            // 
            this.lblCountItemNo.Name = "lblCountItemNo";
            this.lblCountItemNo.Size = new System.Drawing.Size(17, 20);
            this.lblCountItemNo.Text = "0";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Image = global::CarRental.Properties.Resources._0;
            this.pictureBoxMain.Location = new System.Drawing.Point(824, 262);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(205, 125);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Location = new System.Drawing.Point(820, 15);
            this.lblImageList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(115, 16);
            this.lblImageList.TabIndex = 6;
            this.lblImageList.Text = "Vehicle image list:";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Image = global::CarRental.Properties.Resources.Trash_can_icon;
            this.btnDeleteImage.Location = new System.Drawing.Point(980, 34);
            this.btnDeleteImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(45, 41);
            this.btnDeleteImage.TabIndex = 7;
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Image = global::CarRental.Properties.Resources.camera_icon;
            this.btnAddImage.Location = new System.Drawing.Point(820, 34);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(45, 41);
            this.btnAddImage.TabIndex = 8;
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // listViewComments
            // 
            this.listViewComments.HideSelection = false;
            this.listViewComments.Location = new System.Drawing.Point(16, 262);
            this.listViewComments.Margin = new System.Windows.Forms.Padding(4);
            this.listViewComments.Name = "listViewComments";
            this.listViewComments.Size = new System.Drawing.Size(799, 125);
            this.listViewComments.TabIndex = 9;
            this.listViewComments.UseCompatibleStateImageBehavior = false;
            this.listViewComments.View = System.Windows.Forms.View.List;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(16, 395);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.Size = new System.Drawing.Size(1013, 265);
            this.dataGridViewMain.TabIndex = 10;
            this.dataGridViewMain.CurrentCellChanged += new System.EventHandler(this.dataGridViewMain_CurrentCellChanged);
            // 
            // listViewImages
            // 
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(824, 82);
            this.listViewImages.Margin = new System.Windows.Forms.Padding(4);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(204, 171);
            this.listViewImages.TabIndex = 11;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.View = System.Windows.Forms.View.List;
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.listViewImages);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.listViewComments);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblCountItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCountItemNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.ComboBox comboBoxIsRented;
        private System.Windows.Forms.Label lblIsRented;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.ComboBox comboBoxIsDeleted;
        private System.Windows.Forms.Label lblIsDeleted;
        private System.Windows.Forms.ListView listViewComments;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.Button btnCancel;
    }
}